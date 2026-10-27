using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA7 RID: 4007
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSubUV")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UParticleModuleSubUV : UParticleModuleSubUVBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D799 RID: 55193 RVA: 0x0013DE0E File Offset: 0x0013C00E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSubUV._ClassPtr;
		}

		// Token: 0x0600D79A RID: 55194 RVA: 0x0013DE1C File Offset: 0x0013C01C
		public UParticleModuleSubUV() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSubUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D79B RID: 55195 RVA: 0x0013DE44 File Offset: 0x0013C044
		public UParticleModuleSubUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSubUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600D79C RID: 55196 RVA: 0x0013DE77 File Offset: 0x0013C077
		// (set) Token: 0x0600D79D RID: 55197 RVA: 0x0013DE8B File Offset: 0x0013C08B
		[Nullable(2)]
		public unsafe USubUVAnimation Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USubUVAnimation>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleSubUV.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleSubUV.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600D79E RID: 55198 RVA: 0x0013DEA0 File Offset: 0x0013C0A0
		// (set) Token: 0x0600D79F RID: 55199 RVA: 0x0013DED9 File Offset: 0x0013C0D9
		public FRawDistributionFloat SubImageIndex
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SubImageIndex) == null)
				{
					result = (this._SubImageIndex = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSubUV.__PropertyOffset_SubImageIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSubUV.__PropertyOffset_SubImageIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x0013DEFA File Offset: 0x0013C0FA
		// (set) Token: 0x0600D7A1 RID: 55201 RVA: 0x0013DF13 File Offset: 0x0013C113
		public unsafe bool bUseRealTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSubUV.__PropertyOffset_bUseRealTime) & UParticleModuleSubUV.__PropertyMask_bUseRealTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSubUV.__PropertyOffset_bUseRealTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleSubUV.__PropertyOffset_bUseRealTime) & ~UParticleModuleSubUV.__PropertyMask_bUseRealTime) | (value ? UParticleModuleSubUV.__PropertyMask_bUseRealTime : 0));
			}
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x0013DF43 File Offset: 0x0013C143
		static UParticleModuleSubUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSubUV");
		}

		// Token: 0x0600D7A3 RID: 55203 RVA: 0x0013DF51 File Offset: 0x0013C151
		protected UParticleModuleSubUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074AB RID: 29867
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSubUV";

		// Token: 0x040074AC RID: 29868
		private static IntPtr _ClassPtr;

		// Token: 0x040074AD RID: 29869
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040074AE RID: 29870
		internal static int __PropertyOffset_Animation;

		// Token: 0x040074AF RID: 29871
		internal static int __PropertyOffset_SubImageIndex;

		// Token: 0x040074B0 RID: 29872
		[Nullable(2)]
		private FRawDistributionFloat _SubImageIndex;

		// Token: 0x040074B1 RID: 29873
		internal static int __PropertyOffset_bUseRealTime;

		// Token: 0x040074B2 RID: 29874
		internal static byte __PropertyMask_bUseRealTime;
	}
}
