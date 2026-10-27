using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F1 RID: 2033
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimBoneCompressionSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimBoneCompressionSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C7E RID: 27774 RVA: 0x0009C0C5 File Offset: 0x0009A2C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionSettings._ClassPtr;
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x0009C0D4 File Offset: 0x0009A2D4
		public UAnimBoneCompressionSettings() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x0009C0FC File Offset: 0x0009A2FC
		public UAnimBoneCompressionSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x0009C130 File Offset: 0x0009A330
		// (set) Token: 0x06006C82 RID: 27778 RVA: 0x0009C169 File Offset: 0x0009A369
		public TArray<UAnimBoneCompressionCodec> Codecs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimBoneCompressionCodec> result;
				if ((result = this._Codecs) == null)
				{
					result = (this._Codecs = new TArray<UAnimBoneCompressionCodec>(base.NativePtr + (IntPtr)UAnimBoneCompressionSettings.__PropertyOffset_Codecs, this));
				}
				return result;
			}
			set
			{
				this.Codecs.CopyAssign(value);
			}
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x0009C177 File Offset: 0x0009A377
		static UAnimBoneCompressionSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimBoneCompressionSettings");
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x0009C185 File Offset: 0x0009A385
		protected UAnimBoneCompressionSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400343F RID: 13375
		public new const string __ObjectPath = "/Script/Engine.AnimBoneCompressionSettings";

		// Token: 0x04003440 RID: 13376
		private static IntPtr _ClassPtr;

		// Token: 0x04003441 RID: 13377
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003442 RID: 13378
		internal static int __PropertyOffset_Codecs;

		// Token: 0x04003443 RID: 13379
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimBoneCompressionCodec> _Codecs;
	}
}
