using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005B9 RID: 1465
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetDeltaTime")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_GetDeltaTime : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F15 RID: 20245 RVA: 0x00074C85 File Offset: 0x00072E85
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetDeltaTime._ScriptStructPtr != 0) ? FRigUnit_GetDeltaTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetDeltaTime", ref FRigUnit_GetDeltaTime._ScriptStructPtr);
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06004F16 RID: 20246 RVA: 0x00074CA9 File Offset: 0x00072EA9
		// (set) Token: 0x06004F17 RID: 20247 RVA: 0x00074CB9 File Offset: 0x00072EB9
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetDeltaTime.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetDeltaTime.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00074CCA File Offset: 0x00072ECA
		public FRigUnit_GetDeltaTime()
		{
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00074CD2 File Offset: 0x00072ED2
		public FRigUnit_GetDeltaTime(float Result)
		{
			this.Result = Result;
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00074CE1 File Offset: 0x00072EE1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetDeltaTime.StaticStruct();
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00074CED File Offset: 0x00072EED
		[NullableContext(2)]
		public FRigUnit_GetDeltaTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00074CF7 File Offset: 0x00072EF7
		public FRigUnit_GetDeltaTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00074D02 File Offset: 0x00072F02
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetDeltaTime(Pointer, false, true);
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00074D0C File Offset: 0x00072F0C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetDeltaTime(Pointer, MemoryOwner);
		}

		// Token: 0x04002630 RID: 9776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetDeltaTime";

		// Token: 0x04002631 RID: 9777
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002632 RID: 9778
		internal static int __PropertyOffset_Result;
	}
}
