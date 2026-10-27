using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005AB RID: 1451
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FitChainToCurve_Rotation")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_FitChainToCurve_Rotation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E21 RID: 20001 RVA: 0x000736D2 File Offset: 0x000718D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FitChainToCurve_Rotation._ScriptStructPtr != 0) ? FRigUnit_FitChainToCurve_Rotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FitChainToCurve_Rotation", ref FRigUnit_FitChainToCurve_Rotation._ScriptStructPtr);
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x000736F6 File Offset: 0x000718F6
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x0007370A File Offset: 0x0007190A
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_Rotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_Rotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x0007371F File Offset: 0x0007191F
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x0007372F File Offset: 0x0007192F
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_Rotation.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_Rotation.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00073740 File Offset: 0x00071940
		public FRigUnit_FitChainToCurve_Rotation()
		{
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00073748 File Offset: 0x00071948
		public FRigUnit_FitChainToCurve_Rotation(FQuat Rotation, float Ratio)
		{
			this.Rotation = Rotation;
			this.Ratio = Ratio;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x0007375E File Offset: 0x0007195E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FitChainToCurve_Rotation.StaticStruct();
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0007376A File Offset: 0x0007196A
		[NullableContext(2)]
		public FRigUnit_FitChainToCurve_Rotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00073774 File Offset: 0x00071974
		public FRigUnit_FitChainToCurve_Rotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x0007377F File Offset: 0x0007197F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FitChainToCurve_Rotation(Pointer, false, true);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00073789 File Offset: 0x00071989
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FitChainToCurve_Rotation(Pointer, MemoryOwner);
		}

		// Token: 0x040025BE RID: 9662
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_FitChainToCurve_Rotation";

		// Token: 0x040025BF RID: 9663
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025C0 RID: 9664
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040025C1 RID: 9665
		internal static int __PropertyOffset_Ratio;
	}
}
