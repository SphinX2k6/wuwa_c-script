using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058A RID: 1418
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class AKSC_Shape2D_Entity : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008086 RID: 32902 RVA: 0x000BDDBB File Offset: 0x000BBFBB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity._ClassPtr;
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x000BDDC8 File Offset: 0x000BBFC8
		public AKSC_Shape2D_Entity() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x000BDDF0 File Offset: 0x000BBFF0
		[NullableContext(1)]
		public AKSC_Shape2D_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x000BDE23 File Offset: 0x000BC023
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x000BDE37 File Offset: 0x000BC037
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x000BDE4C File Offset: 0x000BC04C
		// (set) Token: 0x0600808C RID: 32908 RVA: 0x000BDE60 File Offset: 0x000BC060
		public unsafe UKSC_Shape2DMove MoveComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2DMove>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_MoveComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_MoveComp_, value);
			}
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x000BDE75 File Offset: 0x000BC075
		public void AssignSkillStateChange(in FOnShape2DSkillStateChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnShape2DSkillStateChange fonShape2DSkillStateChange = InDelegate;
			AKSC_Shape2D_Entity.__AssignSkillStateChange_Internal(nativePtr, (fonShape2DSkillStateChange != null) ? fonShape2DSkillStateChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600808E RID: 32910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignSkillStateChange_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0600808F RID: 32911 RVA: 0x000BDE91 File Offset: 0x000BC091
		static AKSC_Shape2D_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity");
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x000BDE9F File Offset: 0x000BC09F
		protected AKSC_Shape2D_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400381F RID: 14367
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity";

		// Token: 0x04003820 RID: 14368
		private static IntPtr _ClassPtr;

		// Token: 0x04003821 RID: 14369
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003822 RID: 14370
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x04003823 RID: 14371
		internal static int __PropertyOffset_MoveComp_;
	}
}
