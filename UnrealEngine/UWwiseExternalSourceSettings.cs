using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A9A RID: 10906
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseSimpleExternalSource.WwiseExternalSourceSettings")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UWwiseExternalSourceSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028336 RID: 164662 RVA: 0x003D27B3 File Offset: 0x003D09B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseExternalSourceSettings._ClassPtr;
		}

		// Token: 0x06028337 RID: 164663 RVA: 0x003D27C0 File Offset: 0x003D09C0
		public UWwiseExternalSourceSettings() : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028338 RID: 164664 RVA: 0x003D27E8 File Offset: 0x003D09E8
		public UWwiseExternalSourceSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009960 RID: 39264
		// (get) Token: 0x06028339 RID: 164665 RVA: 0x003D281C File Offset: 0x003D0A1C
		// (set) Token: 0x0602833A RID: 164666 RVA: 0x003D2855 File Offset: 0x003D0A55
		public FSoftObjectPath MediaInfoTable
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._MediaInfoTable) == null)
				{
					result = (this._MediaInfoTable = new FSoftObjectPath(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_MediaInfoTable, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_MediaInfoTable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009961 RID: 39265
		// (get) Token: 0x0602833B RID: 164667 RVA: 0x003D2878 File Offset: 0x003D0A78
		// (set) Token: 0x0602833C RID: 164668 RVA: 0x003D28B1 File Offset: 0x003D0AB1
		public FSoftObjectPath ExternalSourceDefaultMedia
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ExternalSourceDefaultMedia) == null)
				{
					result = (this._ExternalSourceDefaultMedia = new FSoftObjectPath(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_ExternalSourceDefaultMedia, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_ExternalSourceDefaultMedia, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009962 RID: 39266
		// (get) Token: 0x0602833D RID: 164669 RVA: 0x003D28D4 File Offset: 0x003D0AD4
		// (set) Token: 0x0602833E RID: 164670 RVA: 0x003D290D File Offset: 0x003D0B0D
		public FDirectoryPath ExternalSourceStagingDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._ExternalSourceStagingDirectory) == null)
				{
					result = (this._ExternalSourceStagingDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_ExternalSourceStagingDirectory, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_ExternalSourceStagingDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009963 RID: 39267
		// (get) Token: 0x0602833F RID: 164671 RVA: 0x003D292E File Offset: 0x003D0B2E
		// (set) Token: 0x06028340 RID: 164672 RVA: 0x003D293E File Offset: 0x003D0B3E
		public unsafe bool bUseKuroExternalSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_bUseKuroExternalSource) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_bUseKuroExternalSource) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009964 RID: 39268
		// (get) Token: 0x06028341 RID: 164673 RVA: 0x003D294F File Offset: 0x003D0B4F
		// (set) Token: 0x06028342 RID: 164674 RVA: 0x003D2963 File Offset: 0x003D0B63
		public unsafe string KuroExternalSourcePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_KuroExternalSourcePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_KuroExternalSourcePath)), value);
			}
		}

		// Token: 0x17009965 RID: 39269
		// (get) Token: 0x06028343 RID: 164675 RVA: 0x003D2978 File Offset: 0x003D0B78
		// (set) Token: 0x06028344 RID: 164676 RVA: 0x003D2988 File Offset: 0x003D0B88
		public unsafe bool bUseLanguageTypes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_bUseLanguageTypes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_bUseLanguageTypes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009966 RID: 39270
		// (get) Token: 0x06028345 RID: 164677 RVA: 0x003D299C File Offset: 0x003D0B9C
		// (set) Token: 0x06028346 RID: 164678 RVA: 0x003D29D5 File Offset: 0x003D0BD5
		public TArray<string> LanguageTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LanguageTypes) == null)
				{
					result = (this._LanguageTypes = new TArray<string>(base.NativePtr + (IntPtr)UWwiseExternalSourceSettings.__PropertyOffset_LanguageTypes, this));
				}
				return result;
			}
			set
			{
				this.LanguageTypes.CopyAssign(value);
			}
		}

		// Token: 0x06028347 RID: 164679 RVA: 0x003D29E3 File Offset: 0x003D0BE3
		static UWwiseExternalSourceSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseSimpleExternalSource.WwiseExternalSourceSettings");
		}

		// Token: 0x06028348 RID: 164680 RVA: 0x003D29F1 File Offset: 0x003D0BF1
		protected UWwiseExternalSourceSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160B0 RID: 90288
		public new const string __ObjectPath = "/Script/WwiseSimpleExternalSource.WwiseExternalSourceSettings";

		// Token: 0x040160B1 RID: 90289
		private static IntPtr _ClassPtr;

		// Token: 0x040160B2 RID: 90290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040160B3 RID: 90291
		internal static int __PropertyOffset_MediaInfoTable;

		// Token: 0x040160B4 RID: 90292
		[Nullable(2)]
		private FSoftObjectPath _MediaInfoTable;

		// Token: 0x040160B5 RID: 90293
		internal static int __PropertyOffset_ExternalSourceDefaultMedia;

		// Token: 0x040160B6 RID: 90294
		[Nullable(2)]
		private FSoftObjectPath _ExternalSourceDefaultMedia;

		// Token: 0x040160B7 RID: 90295
		internal static int __PropertyOffset_ExternalSourceStagingDirectory;

		// Token: 0x040160B8 RID: 90296
		[Nullable(2)]
		private FDirectoryPath _ExternalSourceStagingDirectory;

		// Token: 0x040160B9 RID: 90297
		internal static int __PropertyOffset_bUseKuroExternalSource;

		// Token: 0x040160BA RID: 90298
		internal static int __PropertyOffset_KuroExternalSourcePath;

		// Token: 0x040160BB RID: 90299
		internal static int __PropertyOffset_bUseLanguageTypes;

		// Token: 0x040160BC RID: 90300
		internal static int __PropertyOffset_LanguageTypes;

		// Token: 0x040160BD RID: 90301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LanguageTypes;
	}
}
