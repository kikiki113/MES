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
    
    public partial class 수주
    {
        public string 수주번호 { get; set; }
        public string 수주번호2 { get; set; }
        public string 제품번호 { get; set; }
        public int 주문수량 { get; set; }
        public string 납품업체번호 { get; set; }
        public System.DateTime 주문일 { get; set; }
        public System.DateTime 납기일 { get; set; }
        public Nullable<int> 출고량 { get; set; }
        public int 잔량 { get; set; }
        public int 단가 { get; set; }
        public int 금액 { get; set; }
        public bool 출고여부 { get; set; }
    
        public virtual 거래처 거래처 { get; set; }
        public virtual 제품 제품 { get; set; }
    }
}
