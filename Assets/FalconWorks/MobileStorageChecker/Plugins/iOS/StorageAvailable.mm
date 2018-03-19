//
//  StorageAvailable.mm
//

extern "C"{
    
    /*
     * ストレージ空き容量の取得
     */
    unsigned long long _getStorageAvailable() {
        NSArray *paths = NSSearchPathForDirectoriesInDomains(NSLibraryDirectory, NSUserDomainMask, YES);
        NSDictionary *dict = [[NSFileManager defaultManager] attributesOfFileSystemForPath:[paths lastObject] error:nil];
        
        if (dict) {
            unsigned long long free = [[dict objectForKey: NSFileSystemFreeSize] unsignedLongLongValue];
            return free;
        }
        
        return 0;
    }
    
}
