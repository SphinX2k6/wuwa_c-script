using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E2F RID: 7727
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2DMove")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UKSC_Shape2DMove : UKSC_Move, IUnrealUObject, IUnrealObject, IKSC_Shape2DCustomMoveInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D722 RID: 120610 RVA: 0x002B7DD3 File Offset: 0x002B5FD3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2DMove._ClassPtr;
		}

		// Token: 0x0601D723 RID: 120611 RVA: 0x002B7DDF File Offset: 0x002B5FDF
		int IKSC_Shape2DCustomMoveInterface.InterfaceOffset()
		{
			return UKSC_Shape2DMove.__InterfaceOffset_IKSC_Shape2DCustomMoveInterface;
		}

		// Token: 0x0601D724 RID: 120612 RVA: 0x002B7DE8 File Offset: 0x002B5FE8
		public UKSC_Shape2DMove() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D725 RID: 120613 RVA: 0x002B7E10 File Offset: 0x002B6010
		[NullableContext(1)]
		public UKSC_Shape2DMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076B1 RID: 30385
		// (get) Token: 0x0601D726 RID: 120614 RVA: 0x002B7E43 File Offset: 0x002B6043
		// (set) Token: 0x0601D727 RID: 120615 RVA: 0x002B7E57 File Offset: 0x002B6057
		[Nullable(2)]
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_KscShapeWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x170076B2 RID: 30386
		// (get) Token: 0x0601D728 RID: 120616 RVA: 0x002B7E6C File Offset: 0x002B606C
		// (set) Token: 0x0601D729 RID: 120617 RVA: 0x002B7E80 File Offset: 0x002B6080
		[Nullable(2)]
		public unsafe UCurveFloat MovementCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_MovementCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x0601D72A RID: 120618 RVA: 0x002B7E95 File Offset: 0x002B6095
		public void Launch(float LaunchSpeed, FVector2D Direction, bool ResetFilter = false, bool PlayEffect = false)
		{
			UKSC_Shape2DMove.__Launch_Internal(base.NativePtr, LaunchSpeed, Direction, ResetFilter, PlayEffect);
		}

		// Token: 0x0601D72B RID: 120619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Launch_Internal(IntPtr @this, float LaunchSpeed, FVector2D Direction, bool ResetFilter, bool PlayEffect);

		// Token: 0x0601D72C RID: 120620 RVA: 0x002B7EA7 File Offset: 0x002B60A7
		static UKSC_Shape2DMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2DMove");
		}

		// Token: 0x0601D72D RID: 120621 RVA: 0x002B7EB5 File Offset: 0x002B60B5
		protected UKSC_Shape2DMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF78 RID: 65400
		internal static int __InterfaceOffset_IKSC_Shape2DCustomMoveInterface;

		// Token: 0x0400FF79 RID: 65401
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2DMove";

		// Token: 0x0400FF7A RID: 65402
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF7B RID: 65403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF7C RID: 65404
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x0400FF7D RID: 65405
		internal static int __PropertyOffset_MovementCurve;
	}
}
