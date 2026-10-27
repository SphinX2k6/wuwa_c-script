using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4E RID: 7502
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_BuffEffectIgnoreCollision")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_BuffEffectIgnoreCollision : UKSC_DA_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBC1 RID: 117697 RVA: 0x002A799D File Offset: 0x002A5B9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_BuffEffectIgnoreCollision._ClassPtr;
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x002A79AC File Offset: 0x002A5BAC
		public UKSC_DA_BuffEffectIgnoreCollision() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectIgnoreCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x002A79D4 File Offset: 0x002A5BD4
		[NullableContext(1)]
		public UKSC_DA_BuffEffectIgnoreCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectIgnoreCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073A1 RID: 29601
		// (get) Token: 0x0601CBC4 RID: 117700 RVA: 0x002A7A07 File Offset: 0x002A5C07
		// (set) Token: 0x0601CBC5 RID: 117701 RVA: 0x002A7A17 File Offset: 0x002A5C17
		public unsafe EKSC_ShapeCollisionObjType IgnoreObjType
		{
			get
			{
				return (EKSC_ShapeCollisionObjType)(*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectIgnoreCollision.__PropertyOffset_IgnoreObjType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectIgnoreCollision.__PropertyOffset_IgnoreObjType) = (byte)value;
			}
		}

		// Token: 0x0601CBC6 RID: 117702 RVA: 0x002A7A28 File Offset: 0x002A5C28
		static UKSC_DA_BuffEffectIgnoreCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_BuffEffectIgnoreCollision");
		}

		// Token: 0x0601CBC7 RID: 117703 RVA: 0x002A7A36 File Offset: 0x002A5C36
		protected UKSC_DA_BuffEffectIgnoreCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F949 RID: 63817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_BuffEffectIgnoreCollision";

		// Token: 0x0400F94A RID: 63818
		private static IntPtr _ClassPtr;

		// Token: 0x0400F94B RID: 63819
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F94C RID: 63820
		internal static int __PropertyOffset_IgnoreObjType;
	}
}
