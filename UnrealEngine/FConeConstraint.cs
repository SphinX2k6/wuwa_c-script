using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200096B RID: 2411
	[UnrealObjectPath("/Script/Engine.ConeConstraint")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FConeConstraint : FConstraintBaseParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600881A RID: 34842 RVA: 0x000C3023 File Offset: 0x000C1223
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConeConstraint._ScriptStructPtr != 0) ? FConeConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConeConstraint", ref FConeConstraint._ScriptStructPtr);
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600881B RID: 34843 RVA: 0x000C3047 File Offset: 0x000C1247
		// (set) Token: 0x0600881C RID: 34844 RVA: 0x000C3057 File Offset: 0x000C1257
		public unsafe float Swing1LimitDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing1LimitDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing1LimitDegrees) = value;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600881D RID: 34845 RVA: 0x000C3068 File Offset: 0x000C1268
		// (set) Token: 0x0600881E RID: 34846 RVA: 0x000C3078 File Offset: 0x000C1278
		public unsafe float Swing2LimitDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing2LimitDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing2LimitDegrees) = value;
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x000C3089 File Offset: 0x000C1289
		// (set) Token: 0x06008820 RID: 34848 RVA: 0x000C309D File Offset: 0x000C129D
		public unsafe TEnumAsByte<EAngularConstraintMotion> Swing1Motion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing1Motion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing1Motion) = value;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06008821 RID: 34849 RVA: 0x000C30B2 File Offset: 0x000C12B2
		// (set) Token: 0x06008822 RID: 34850 RVA: 0x000C30C6 File Offset: 0x000C12C6
		public unsafe TEnumAsByte<EAngularConstraintMotion> Swing2Motion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing2Motion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConeConstraint.__PropertyOffset_Swing2Motion) = value;
			}
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x000C30DB File Offset: 0x000C12DB
		public FConeConstraint()
		{
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x000C30E4 File Offset: 0x000C12E4
		public FConeConstraint(float Swing1LimitDegrees, float Swing2LimitDegrees, TEnumAsByte<EAngularConstraintMotion> Swing1Motion, TEnumAsByte<EAngularConstraintMotion> Swing2Motion, float Stiffness, float Damping, float Restitution, float ContactDistance, bool bSoftConstraint)
		{
			this.Swing1LimitDegrees = Swing1LimitDegrees;
			this.Swing2LimitDegrees = Swing2LimitDegrees;
			this.Swing1Motion = Swing1Motion;
			this.Swing2Motion = Swing2Motion;
			base.Stiffness = Stiffness;
			base.Damping = Damping;
			base.Restitution = Restitution;
			base.ContactDistance = ContactDistance;
			base.bSoftConstraint = bSoftConstraint;
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x000C313C File Offset: 0x000C133C
		protected override IntPtr GetUStructPtr()
		{
			return FConeConstraint.StaticStruct();
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x000C3148 File Offset: 0x000C1348
		[NullableContext(2)]
		public FConeConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x000C3152 File Offset: 0x000C1352
		public FConeConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x000C315D File Offset: 0x000C135D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConeConstraint(Pointer, false, true);
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x000C3167 File Offset: 0x000C1367
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConeConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040040B5 RID: 16565
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ConeConstraint";

		// Token: 0x040040B6 RID: 16566
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040B7 RID: 16567
		internal static int __PropertyOffset_Swing1LimitDegrees;

		// Token: 0x040040B8 RID: 16568
		internal static int __PropertyOffset_Swing2LimitDegrees;

		// Token: 0x040040B9 RID: 16569
		internal static int __PropertyOffset_Swing1Motion;

		// Token: 0x040040BA RID: 16570
		internal static int __PropertyOffset_Swing2Motion;
	}
}
