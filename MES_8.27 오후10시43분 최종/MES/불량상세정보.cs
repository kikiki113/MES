//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES
{
    using System;
    using System.Collections.Generic;
    
    public partial class 불량상세정보
    {
        public string 입고등록번호 { get; set; }
        public string 불량코드번호 { get; set; }
        public string 자재번호 { get; set; }
        public int 불량수량 { get; set; }
    
        public virtual 불량코드내역 불량코드내역 { get; set; }
        public virtual 입고등록리스트 입고등록리스트 { get; set; }
    }
}
