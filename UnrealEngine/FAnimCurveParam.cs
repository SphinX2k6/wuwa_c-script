using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000805 RID: 2053
	[UnrealObjectPath("/Script/Engine.AnimCurveParam")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimCurveParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D6E RID: 28014 RVA: 0x0009D85F File Offset: 0x0009BA5F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimCurveParam._ScriptStructPtr != 0) ? FAnimCurveParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimCurveParam", ref FAnimCurveParam._ScriptStructPtr);
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x0009D883 File Offset: 0x0009BA83
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x0009D897 File Offset: 0x0009BA97
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimCurveParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimCurveParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x0009D8AC File Offset: 0x0009BAAC
		public FAnimCurveParam()
		{
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x0009D8B4 File Offset: 0x0009BAB4
		public FAnimCurveParam(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x0009D8C3 File Offset: 0x0009BAC3
		protected override IntPtr GetUStructPtr()
		{
			return FAnimCurveParam.StaticStruct();
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x0009D8CF File Offset: 0x0009BACF
		[NullableContext(2)]
		public FAnimCurveParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x0009D8D9 File Offset: 0x0009BAD9
		public FAnimCurveParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x0009D8E4 File Offset: 0x0009BAE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimCurveParam(Pointer, false, true);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x0009D8EE File Offset: 0x0009BAEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimCurveParam(Pointer, MemoryOwner);
		}

		// Token: 0x040034DF RID: 13535
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimCurveParam";

		// Token: 0x040034E0 RID: 13536
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034E1 RID: 13537
		internal static int __PropertyOffset_Name;
	}
}
