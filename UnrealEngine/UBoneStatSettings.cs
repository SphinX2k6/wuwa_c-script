using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008DE RID: 2270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneStatSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UBoneStatSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007CB9 RID: 31929 RVA: 0x000B2D4C File Offset: 0x000B0F4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoneStatSettings._ClassPtr;
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x000B2D58 File Offset: 0x000B0F58
		public UBoneStatSettings() : this(BuiltinUtils.AllocNativeUObject(UBoneStatSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x000B2D80 File Offset: 0x000B0F80
		public UBoneStatSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoneStatSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06007CBC RID: 31932 RVA: 0x000B2DB4 File Offset: 0x000B0FB4
		// (set) Token: 0x06007CBD RID: 31933 RVA: 0x000B2DED File Offset: 0x000B0FED
		public TArray<string> AuxiliaryBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AuxiliaryBones) == null)
				{
					result = (this._AuxiliaryBones = new TArray<string>(base.NativePtr + (IntPtr)UBoneStatSettings.__PropertyOffset_AuxiliaryBones, this));
				}
				return result;
			}
			set
			{
				this.AuxiliaryBones.CopyAssign(value);
			}
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x000B2DFB File Offset: 0x000B0FFB
		static UBoneStatSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoneStatSettings");
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x000B2E09 File Offset: 0x000B1009
		protected UBoneStatSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BC5 RID: 15301
		public new const string __ObjectPath = "/Script/Engine.BoneStatSettings";

		// Token: 0x04003BC6 RID: 15302
		private static IntPtr _ClassPtr;

		// Token: 0x04003BC7 RID: 15303
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BC8 RID: 15304
		internal static int __PropertyOffset_AuxiliaryBones;

		// Token: 0x04003BC9 RID: 15305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AuxiliaryBones;
	}
}
