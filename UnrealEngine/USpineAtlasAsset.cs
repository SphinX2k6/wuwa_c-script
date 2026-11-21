using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083D RID: 2109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineAtlasAsset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USpineAtlasAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7C2 RID: 47042 RVA: 0x001269B1 File Offset: 0x00124BB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineAtlasAsset._ClassPtr;
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x001269C0 File Offset: 0x00124BC0
		public USpineAtlasAsset() : this(BuiltinUtils.AllocNativeUObject(USpineAtlasAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x001269E8 File Offset: 0x00124BE8
		public USpineAtlasAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineAtlasAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600B7C5 RID: 47045 RVA: 0x00126A1C File Offset: 0x00124C1C
		// (set) Token: 0x0600B7C6 RID: 47046 RVA: 0x00126A55 File Offset: 0x00124C55
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

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600B7C7 RID: 47047 RVA: 0x00126A63 File Offset: 0x00124C63
		// (set) Token: 0x0600B7C8 RID: 47048 RVA: 0x00126A77 File Offset: 0x00124C77
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

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x00126A8C File Offset: 0x00124C8C
		// (set) Token: 0x0600B7CA RID: 47050 RVA: 0x00126AA0 File Offset: 0x00124CA0
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

		// Token: 0x0600B7CB RID: 47051 RVA: 0x00126AB5 File Offset: 0x00124CB5
		static USpineAtlasAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineAtlasAsset");
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x00126AC3 File Offset: 0x00124CC3
		protected USpineAtlasAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400537D RID: 21373
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineAtlasAsset";

		// Token: 0x0400537E RID: 21374
		private static IntPtr _ClassPtr;

		// Token: 0x0400537F RID: 21375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005380 RID: 21376
		internal static int __PropertyOffset_atlasPages;

		// Token: 0x04005381 RID: 21377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _atlasPages;

		// Token: 0x04005382 RID: 21378
		internal static int __PropertyOffset_rawData;

		// Token: 0x04005383 RID: 21379
		internal static int __PropertyOffset_atlasFileName;
	}
}
