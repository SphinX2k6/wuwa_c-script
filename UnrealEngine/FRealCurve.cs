using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000270 RID: 624
	[UnrealObjectPath("/Script/Engine.RealCurve")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRealCurve : FIndexedCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x0005C0F5 File Offset: 0x0005A2F5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRealCurve._ScriptStructPtr != 0) ? FRealCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RealCurve", ref FRealCurve._ScriptStructPtr);
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x0005C119 File Offset: 0x0005A319
		// (set) Token: 0x06004027 RID: 16423 RVA: 0x0005C129 File Offset: 0x0005A329
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x0005C13A File Offset: 0x0005A33A
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x0005C14E File Offset: 0x0005A34E
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PreInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PreInfinityExtrap) = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x0005C163 File Offset: 0x0005A363
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x0005C177 File Offset: 0x0005A377
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PostInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PostInfinityExtrap) = value;
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x0005C18C File Offset: 0x0005A38C
		public FRealCurve()
		{
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0005C194 File Offset: 0x0005A394
		protected override IntPtr GetUStructPtr()
		{
			return FRealCurve.StaticStruct();
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0005C1A0 File Offset: 0x0005A3A0
		[NullableContext(2)]
		public FRealCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x0005C1AA File Offset: 0x0005A3AA
		public FRealCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0005C1B5 File Offset: 0x0005A3B5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRealCurve(Pointer, false, true);
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x0005C1BF File Offset: 0x0005A3BF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRealCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04001917 RID: 6423
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RealCurve";

		// Token: 0x04001918 RID: 6424
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001919 RID: 6425
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x0400191A RID: 6426
		internal static int __PropertyOffset_PreInfinityExtrap;

		// Token: 0x0400191B RID: 6427
		internal static int __PropertyOffset_PostInfinityExtrap;
	}
}
