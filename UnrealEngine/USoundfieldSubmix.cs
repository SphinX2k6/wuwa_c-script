using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001132 RID: 4402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundfieldSubmix")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class USoundfieldSubmix : USoundSubmixWithParentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060101B4 RID: 65972 RVA: 0x0017BAF2 File Offset: 0x00179CF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldSubmix._ClassPtr;
		}

		// Token: 0x060101B5 RID: 65973 RVA: 0x0017BB00 File Offset: 0x00179D00
		public USoundfieldSubmix() : this(BuiltinUtils.AllocNativeUObject(USoundfieldSubmix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060101B6 RID: 65974 RVA: 0x0017BB28 File Offset: 0x00179D28
		public USoundfieldSubmix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundfieldSubmix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x060101B7 RID: 65975 RVA: 0x0017BB5B File Offset: 0x00179D5B
		// (set) Token: 0x060101B8 RID: 65976 RVA: 0x0017BB6F File Offset: 0x00179D6F
		public unsafe FName SoundfieldEncodingFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundfieldSubmix.__PropertyOffset_SoundfieldEncodingFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundfieldSubmix.__PropertyOffset_SoundfieldEncodingFormat) = value;
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x060101B9 RID: 65977 RVA: 0x0017BB84 File Offset: 0x00179D84
		// (set) Token: 0x060101BA RID: 65978 RVA: 0x0017BB98 File Offset: 0x00179D98
		[Nullable(2)]
		public unsafe USoundfieldEncodingSettingsBase EncodingSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundfieldEncodingSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldSubmix.__PropertyOffset_EncodingSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldSubmix.__PropertyOffset_EncodingSettings, value);
			}
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x060101BB RID: 65979 RVA: 0x0017BBB0 File Offset: 0x00179DB0
		// (set) Token: 0x060101BC RID: 65980 RVA: 0x0017BBE9 File Offset: 0x00179DE9
		public TArray<USoundfieldEffectBase> SoundfieldEffectChain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USoundfieldEffectBase> result;
				if ((result = this._SoundfieldEffectChain) == null)
				{
					result = (this._SoundfieldEffectChain = new TArray<USoundfieldEffectBase>(base.NativePtr + (IntPtr)USoundfieldSubmix.__PropertyOffset_SoundfieldEffectChain, this));
				}
				return result;
			}
			set
			{
				this.SoundfieldEffectChain.CopyAssign(value);
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x060101BD RID: 65981 RVA: 0x0017BBF7 File Offset: 0x00179DF7
		// (set) Token: 0x060101BE RID: 65982 RVA: 0x0017BC0B File Offset: 0x00179E0B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USoundfieldEncodingSettingsBase> EncodingSettingsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USoundfieldSubmix.__PropertyOffset_EncodingSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USoundfieldSubmix.__PropertyOffset_EncodingSettingsClass) = value;
			}
		}

		// Token: 0x060101BF RID: 65983 RVA: 0x0017BC20 File Offset: 0x00179E20
		static USoundfieldSubmix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundfieldSubmix");
		}

		// Token: 0x060101C0 RID: 65984 RVA: 0x0017BC2E File Offset: 0x00179E2E
		protected USoundfieldSubmix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A96 RID: 35478
		public new const string __ObjectPath = "/Script/Engine.SoundfieldSubmix";

		// Token: 0x04008A97 RID: 35479
		private static IntPtr _ClassPtr;

		// Token: 0x04008A98 RID: 35480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A99 RID: 35481
		internal static int __PropertyOffset_SoundfieldEncodingFormat;

		// Token: 0x04008A9A RID: 35482
		internal static int __PropertyOffset_EncodingSettings;

		// Token: 0x04008A9B RID: 35483
		internal static int __PropertyOffset_SoundfieldEffectChain;

		// Token: 0x04008A9C RID: 35484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundfieldEffectBase> _SoundfieldEffectChain;

		// Token: 0x04008A9D RID: 35485
		internal static int __PropertyOffset_EncodingSettingsClass;
	}
}
