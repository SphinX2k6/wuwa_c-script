using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC6 RID: 3782
	[UnrealObjectPath("/Script/Engine.NamedCurveValue")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNamedCurveValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCBC RID: 52412 RVA: 0x0012A474 File Offset: 0x00128674
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedCurveValue._ScriptStructPtr != 0) ? FNamedCurveValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedCurveValue", ref FNamedCurveValue._ScriptStructPtr);
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x0012A498 File Offset: 0x00128698
		// (set) Token: 0x0600CCBE RID: 52414 RVA: 0x0012A4AC File Offset: 0x001286AC
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedCurveValue.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedCurveValue.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x0012A4C1 File Offset: 0x001286C1
		// (set) Token: 0x0600CCC0 RID: 52416 RVA: 0x0012A4D1 File Offset: 0x001286D1
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedCurveValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedCurveValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x0012A4E2 File Offset: 0x001286E2
		public FNamedCurveValue()
		{
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x0012A4EA File Offset: 0x001286EA
		public FNamedCurveValue(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x0012A500 File Offset: 0x00128700
		protected override IntPtr GetUStructPtr()
		{
			return FNamedCurveValue.StaticStruct();
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x0012A50C File Offset: 0x0012870C
		[NullableContext(2)]
		public FNamedCurveValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x0012A516 File Offset: 0x00128716
		public FNamedCurveValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x0012A521 File Offset: 0x00128721
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedCurveValue(Pointer, false, true);
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x0012A52B File Offset: 0x0012872B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedCurveValue(Pointer, MemoryOwner);
		}

		// Token: 0x04006E3A RID: 28218
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedCurveValue";

		// Token: 0x04006E3B RID: 28219
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E3C RID: 28220
		internal static int __PropertyOffset_Name;

		// Token: 0x04006E3D RID: 28221
		internal static int __PropertyOffset_Value;
	}
}
