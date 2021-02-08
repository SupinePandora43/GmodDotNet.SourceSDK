#include <filesystem.h>

#pragma region IBaseFileSystem

DLL_EXPORT int IBaseFileSystem_Read(void** ptr, void* pOutput, int size, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Read(pOutput, size, file);
}

DLL_EXPORT int IBaseFileSystem_Write(void** ptr, void const* pInput, int size, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Write(pInput, size, file);
}

DLL_EXPORT FileHandle_t IBaseFileSystem_Open(void** ptr, const char* pFileName, const char* pOptions, const char* pathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Open(pFileName, pOptions, pathID);
}

DLL_EXPORT void IBaseFileSystem_Close(void** ptr, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	bfs->Close(file);
}

DLL_EXPORT void IBaseFileSystem_Seek(void** ptr, FileHandle_t file, int pos, FileSystemSeek_t seekType) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	bfs->Seek(file, pos, seekType);
}

DLL_EXPORT unsigned int IBaseFileSystem_Tell(void** ptr, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Tell(file);
}

DLL_EXPORT unsigned int IBaseFileSystem_Size(void** ptr, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Size(file);
}

DLL_EXPORT unsigned int IBaseFileSystem_Size_string_string(void** ptr, const char* pFileName, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Size(pFileName, pPathID);
}

DLL_EXPORT void IBaseFileSystem_Flush(void** ptr, FileHandle_t file) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	bfs->Flush(file);
}

DLL_EXPORT bool IBaseFileSystem_Precache(void** ptr, const char* pFileName, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->Precache(pFileName, pPathID);
}

DLL_EXPORT bool IBaseFileSystem_FileExists(void** ptr, const char* pFileName, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->FileExists(pFileName, pPathID);
}

DLL_EXPORT bool IBaseFileSystem_IsFileWritable(void** ptr, const char* pFileName, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->IsFileWritable(pFileName, pPathID);
}

DLL_EXPORT bool IBaseFileSystem_SetFileWritable(void** ptr, char const* pFileName, bool writable, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->SetFileWritable(pFileName, writable, pPathID);
}

DLL_EXPORT long IBaseFileSystem_GetFileTime(void** ptr, const char* pFileName, const char* pPathID = 0) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->GetFileTime(pFileName, pPathID);
}


DLL_EXPORT bool IBaseFileSystem_ReadFile(void** ptr, const char* pFileName, const char* pPath, CUtlBuffer& buf, int nMaxBytes = 0, int nStartingByte = 0, FSAllocFunc_t pfnAlloc = NULL) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->ReadFile(pFileName, pPath, buf, nMaxBytes, nStartingByte, pfnAlloc);
}

DLL_EXPORT bool IBaseFileSystem_WriteFile(void** ptr, const char* pFileName, const char* pPath, CUtlBuffer& buf) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->WriteFile(pFileName, pPath, buf);
}

DLL_EXPORT bool IBaseFileSystem_UnzipFile(void** ptr, const char* pFileName, const char* pPath, const char* pDestination) {
	IBaseFileSystem* bfs = (IBaseFileSystem*)ptr;
	return bfs->UnzipFile(pFileName, pPath, pDestination);
}
#pragma endregion

DLL_EXPORT bool IFileSystem_IsSteam(void** fsPtr) {
	IFileSystem* fs = (IFileSystem*)fsPtr;
	return fs->IsSteam();
}

DLL_EXPORT void IFileSystem_PrintSearchPaths(void** fsPtr) {
	IFileSystem* fs = (IFileSystem*)fsPtr;
	fs->PrintSearchPaths();
}