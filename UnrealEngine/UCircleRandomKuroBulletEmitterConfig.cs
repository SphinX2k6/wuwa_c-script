using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016D2 RID: 5842
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.CircleRandomKuroBulletEmitterConfig")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UCircleRandomKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015296 RID: 86678 RVA: 0x001F1AE7 File Offset: 0x001EFCE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCircleRandomKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x06015297 RID: 86679 RVA: 0x001F1AF4 File Offset: 0x001EFCF4
		public UCircleRandomKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UCircleRandomKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015298 RID: 86680 RVA: 0x001F1B1C File Offset: 0x001EFD1C
		public UCircleRandomKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCircleRandomKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053A2 RID: 21410
		// (get) Token: 0x06015299 RID: 86681 RVA: 0x001F1B4F File Offset: 0x001EFD4F
		// (set) Token: 0x0601529A RID: 86682 RVA: 0x001F1B5F File Offset: 0x001EFD5F
		public unsafe float BaseRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCircleRandomKuroBulletEmitterConfig.__PropertyOffset_BaseRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCircleRandomKuroBulletEmitterConfig.__PropertyOffset_BaseRadius) = value;
			}
		}

		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x0601529B RID: 86683 RVA: 0x001F1B70 File Offset: 0x001EFD70
		// (set) Token: 0x0601529C RID: 86684 RVA: 0x001F1BA9 File Offset: 0x001EFDA9
		public TArray<FCircleRandomEmitterSettings> CircleRandomSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCircleRandomEmitterSettings> result;
				if ((result = this._CircleRandomSettings) == null)
				{
					result = (this._CircleRandomSettings = new TArray<FCircleRandomEmitterSettings>(base.NativePtr + (IntPtr)UCircleRandomKuroBulletEmitterConfig.__PropertyOffset_CircleRandomSettings, this));
				}
				return result;
			}
			set
			{
				this.CircleRandomSettings.CopyAssign(value);
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x0601529D RID: 86685 RVA: 0x001F1BB8 File Offset: 0x001EFDB8
		// (set) Token: 0x0601529E RID: 86686 RVA: 0x001F1BF1 File Offset: 0x001EFDF1
		public FEmitterStackSettings StackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterStackSettings result;
				if ((result = this._StackSettings) == null)
				{
					result = (this._StackSettings = new FEmitterStackSettings(base.NativePtr + (IntPtr)UCircleRandomKuroBulletEmitterConfig.__PropertyOffset_StackSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterStackSettings.StaticStruct(), base.NativePtr + (IntPtr)UCircleRandomKuroBulletEmitterConfig.__PropertyOffset_StackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601529F RID: 86687 RVA: 0x001F1C12 File Offset: 0x001EFE12
		static UCircleRandomKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.CircleRandomKuroBulletEmitterConfig");
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x001F1C20 File Offset: 0x001EFE20
		protected UCircleRandomKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B82F RID: 47151
		public new const string __ObjectPath = "/Script/KuroBulletCore.CircleRandomKuroBulletEmitterConfig";

		// Token: 0x0400B830 RID: 47152
		private static IntPtr _ClassPtr;

		// Token: 0x0400B831 RID: 47153
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B832 RID: 47154
		internal static int __PropertyOffset_BaseRadius;

		// Token: 0x0400B833 RID: 47155
		internal static int __PropertyOffset_CircleRandomSettings;

		// Token: 0x0400B834 RID: 47156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCircleRandomEmitterSettings> _CircleRandomSettings;

		// Token: 0x0400B835 RID: 47157
		internal static int __PropertyOffset_StackSettings;

		// Token: 0x0400B836 RID: 47158
		[Nullable(2)]
		private FEmitterStackSettings _StackSettings;
	}
}
