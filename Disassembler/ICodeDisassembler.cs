using KARE8080.Loader;

namespace KARE8080
{
    interface ICodeDisassembler
    {
        string Disassemble(ICodeLoader loader);
    }
}