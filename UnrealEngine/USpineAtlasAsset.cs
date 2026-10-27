using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028AB RID: 10411
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineAtlasAsset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USpineAtlasAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602699C RID: 158108 RVA: 0x003AE7ED File Offset: 0x003AC9ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineAtlasAsset._ClassPtr;
		}

		// Token: 0x0602699D RID: 158109 RVA: 0x003AE7FC File Offset: 0x003AC9FC
		public USpineAtlasAsset() : this(BuiltinUtils.AllocNativeUObject(USpineAtlasAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602699E RID: 158110 RVA: 0x003AE824 File Offset: 0x003ACA24
		public USpineAtlasAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineAtlasAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094CC RID: 38092
		// (get) Token: 0x0602699F RID: 158111 RVA: 0x003AE858 File Offset: 0x003ACA58
		// (set) Token: 0x060269A0 RID: 158112 RVA: 0x003AE891 File Offset: 0x003ACA91
		public TArray<UTexture2D> atlasPages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._atlasPages) == null)
				{
					result = (this._atlasPages = new TArray<UTexture2D>(base.NativePtr + (IntPtr)USpineAtlasAsset.__PropertyOffset_atlasPages, this));
				}
				return result;
			}
			set
			{
				this.atlasPages.CopyAssign(value);
			}
		}

		// Token: 0x170094CD RID: 38093
		// (get) Token: 0x060269A1 RID: 158113 RVA: 0x003AE89F File Offset: 0x003ACA9F
		// (set) Token: 0x060269A2 RID: 158114 RVA: 0x003AE8B3 File Offset: 0x003ACAB3
		public unsafe string rawData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineAtlasAsset.__PropertyOffset_rawData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineAtlasAsset.__PropertyOffset_rawData)), value);
			}
		}

		// Token: 0x170094CE RID: 38094
		// (get) Token: 0x060269A3 RID: 158115 RVA: 0x003AE8C8 File Offset: 0x003ACAC8
		// (set) Token: 0x060269A4 RID: 158116 RVA: 0x003AE8DC File Offset: 0x003ACADC
		public unsafe FName atlasFileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineAtlasAsset.__PropertyOffset_atlasFileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineAtlasAsset.__PropertyOffset_atlasFileName) = value;
			}
		}

		// Token: 0x060269A5 RID: 158117 RVA: 0x003AE8F1 File Offset: 0x003ACAF1
		static USpineAtlasAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineAtlasAsset");
		}

		// Token: 0x060269A6 RID: 158118 RVA: 0x003AE8FF File Offset: 0x003ACAFF
		protected USpineAtlasAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015338 RID: 86840
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineAtlasAsset";

		// Token: 0x04015339 RID: 86841
		private static IntPtr _ClassPtr;

		// Token: 0x0401533A RID: 86842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401533B RID: 86843
		internal static int __PropertyOffset_atlasPages;

		// Token: 0x0401533C RID: 86844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _atlasPages;

		// Token: 0x0401533D RID: 86845
		internal static int __PropertyOffset_rawData;

		// Token: 0x0401533E RID: 86846
		internal static int __PropertyOffset_atlasFileName;
	}
}
