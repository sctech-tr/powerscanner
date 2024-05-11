import os
import hashlib
import requests
import time
import sys

def fetch_malware_signatures():
    sign0 = "https://virusshare.com/hashfiles/VirusShare_00355.md5"
    sign1 = "https://virusshare.com/hashfiles/VirusShare_00356.md5"
    sign2 = "https://virusshare.com/hashfiles/VirusShare_00357.md5"
    sign3 = "https://virusshare.com/hashfiles/VirusShare_00358.md5"
    sign4 = "https://virusshare.com/hashfiles/VirusShare_00359.md5"
    sign5 = "https://virusshare.com/hashfiles/VirusShare_00360.md5"
    sign6 = "https://virusshare.com/hashfiles/VirusShare_00361.md5"
    sign7 = "https://virusshare.com/hashfiles/VirusShare_00362.md5"
    eicar = "44d88612fea8a8f36de82e1278abb02f"
    malware_signatures = [eicar]

    for sign in [sign0, sign1, sign2, sign3, sign4, sign5, sign6, sign7]:
        response = requests.get(sign)

        if response.status_code == 200:
            malware_signatures.extend(response.text.splitlines()[6:])
        else:
            print("Failed to fetch malware signatures from server. AeroTotal Scanner will now quit.")
            time.sleep(5)
            sys.exit()

    return malware_signatures
    
def scan_directory(directory, malware_signatures):
    detected_malware = []
    for root, dirs, files in os.walk(directory):
        for file in files:
            file_path = os.path.join(root, file)
            file_hash = calculate_file_hash(file_path)
            if file_hash in malware_signatures:
                detected_malware.append(file_path)

    return detected_malware
    
def calculate_file_hash(file_path):
    md5 = hashlib.md5()
    with open(file_path, "rb") as f:
        for chunk in iter(lambda: f.read(4096), b""):
            md5.update(chunk)
    return md5.hexdigest()

scan_directory_path = input("Enter the directory path to scan for malware: ")
malware_signatures = fetch_malware_signatures()
detected_malware = scan_directory(scan_directory_path, malware_signatures)

if detected_malware:
    print("Detected files:")
    for file in detected_malware:
        print(file)
    user_input = input("Do you want to delete the detected files? (y/n): ")
    if user_input.lower() == "y":
        for file in detected_malware:
            try:
                os.remove(file)
                print(f"Deleted file(s): {file}")
            except OSError as e:
                print(f"Error deleting file(s) {file}: {e}")
    elif user_input.lower() ==  "n":
        print(f"The file(s) {file} are not deleted.")
else:
    print("No malware detected.")
    time.sleep(5)