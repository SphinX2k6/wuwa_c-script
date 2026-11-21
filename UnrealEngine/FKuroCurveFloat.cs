using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200035E RID: 862
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveFloat")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCurveFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005846 RID: 22598 RVA: 0x0007C75D File Offset: 0x0007A95D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveFloat._ScriptStructPtr != 0) ? FKuroCurveFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveFloat", ref FKuroCurveFloat._ScriptStructPtr);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06005847 RID: 22599 RVA: 0x0007C781 File Offset: 0x0007A981
		// (set) Token: 0x06005848 RID: 22600 RVA: 0x0007C79A File Offset: 0x0007A99A
		public unsafe bool bUseCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) & FKuroCurveFloat.__PropertyMask_bUseCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) = ((*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) & ~FKuroCurveFloat.__PropertyMask_bUseCurve) | (value ? FKuroCurveFloat.__PropertyMask_bUseCurve : 0));
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005849 RID: 22601 RVA: 0x0007C7CA File Offset: 0x0007A9CA
		// (set) Token: 0x0600584A RID: 22602 RVA: 0x0007C7DA File Offset: 0x0007A9DA
		public unsafe float Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0007C7EB File Offset: 0x0007A9EB
		public FKuroCurveFloat()
		{
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x0007C7F3 File Offset: 0x0007A9F3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveFloat.StaticStruct();
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x0007C7FF File Offset: 0x0007A9FF
		[NullableContext(2)]
		public FKuroCurveFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x0007C809 File Offset: 0x0007AA09
		public FKuroCurveFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x0007C814 File Offset: 0x0007AA14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveFloat(Pointer, false, true);
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x0007C81E File Offset: 0x0007AA1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002479 RID: 9337
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveFloat";

		// Token: 0x0400247A RID: 9338
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400247B RID: 9339
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400247C RID: 9340
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400247D RID: 9341
		internal static int __PropertyOffset_Constant;
	}
}
