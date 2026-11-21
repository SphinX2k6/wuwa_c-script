using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000587 RID: 1415
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2DMove")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UKSC_Shape2DMove : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600805B RID: 32859 RVA: 0x000BDAF0 File Offset: 0x000BBCF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2DMove._ClassPtr;
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x000BDAFC File Offset: 0x000BBCFC
		public UKSC_Shape2DMove() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x000BDB24 File Offset: 0x000BBD24
		[NullableContext(1)]
		public UKSC_Shape2DMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600805E RID: 32862 RVA: 0x000BDB57 File Offset: 0x000BBD57
		// (set) Token: 0x0600805F RID: 32863 RVA: 0x000BDB6B File Offset: 0x000BBD6B
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06008060 RID: 32864 RVA: 0x000BDB80 File Offset: 0x000BBD80
		// (set) Token: 0x06008061 RID: 32865 RVA: 0x000BDB94 File Offset: 0x000BBD94
		public unsafe UCurveFloat MovementCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_MovementCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x000BDBA9 File Offset: 0x000BBDA9
		public void Launch(float LaunchSpeed, FVector2D Direction, bool ResetFilter = false, bool PlayEffect = false)
		{
			UKSC_Shape2DMove.__Launch_Internal(base.NativePtr, LaunchSpeed, Direction, ResetFilter, PlayEffect);
		}

		// Token: 0x06008063 RID: 32867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Launch_Internal(IntPtr @this, float LaunchSpeed, FVector2D Direction, bool ResetFilter, bool PlayEffect);

		// Token: 0x06008064 RID: 32868 RVA: 0x000BDBBB File Offset: 0x000BBDBB
		static UKSC_Shape2DMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2DMove");
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x000BDBC9 File Offset: 0x000BBDC9
		protected UKSC_Shape2DMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400380D RID: 14349
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2DMove";

		// Token: 0x0400380E RID: 14350
		private static IntPtr _ClassPtr;

		// Token: 0x0400380F RID: 14351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003810 RID: 14352
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x04003811 RID: 14353
		internal static int __PropertyOffset_MovementCurve;
	}
}
