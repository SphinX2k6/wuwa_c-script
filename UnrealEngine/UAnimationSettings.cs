using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E4 RID: 2020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimationSettings")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UAnimationSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B97 RID: 27543 RVA: 0x0009ACE4 File Offset: 0x00098EE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationSettings._ClassPtr;
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x0009ACF0 File Offset: 0x00098EF0
		public UAnimationSettings() : this(BuiltinUtils.AllocNativeUObject(UAnimationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x0009AD18 File Offset: 0x00098F18
		public UAnimationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06006B9A RID: 27546 RVA: 0x0009AD4B File Offset: 0x00098F4B
		// (set) Token: 0x06006B9B RID: 27547 RVA: 0x0009AD5B File Offset: 0x00098F5B
		public unsafe int CompressCommandletVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_CompressCommandletVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_CompressCommandletVersion) = value;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06006B9C RID: 27548 RVA: 0x0009AD6C File Offset: 0x00098F6C
		// (set) Token: 0x06006B9D RID: 27549 RVA: 0x0009ADA5 File Offset: 0x00098FA5
		public TArray<string> KeyEndEffectorsMatchNameArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._KeyEndEffectorsMatchNameArray) == null)
				{
					result = (this._KeyEndEffectorsMatchNameArray = new TArray<string>(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_KeyEndEffectorsMatchNameArray, this));
				}
				return result;
			}
			set
			{
				this.KeyEndEffectorsMatchNameArray.CopyAssign(value);
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x0009ADB3 File Offset: 0x00098FB3
		// (set) Token: 0x06006B9F RID: 27551 RVA: 0x0009ADC3 File Offset: 0x00098FC3
		public unsafe bool ForceRecompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_ForceRecompression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_ForceRecompression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x0009ADD4 File Offset: 0x00098FD4
		// (set) Token: 0x06006BA1 RID: 27553 RVA: 0x0009ADE4 File Offset: 0x00098FE4
		public unsafe bool bForceBelowThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bForceBelowThreshold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bForceBelowThreshold) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06006BA2 RID: 27554 RVA: 0x0009ADF5 File Offset: 0x00098FF5
		// (set) Token: 0x06006BA3 RID: 27555 RVA: 0x0009AE05 File Offset: 0x00099005
		public unsafe bool bFirstRecompressUsingCurrentOrDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bFirstRecompressUsingCurrentOrDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bFirstRecompressUsingCurrentOrDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x0009AE16 File Offset: 0x00099016
		// (set) Token: 0x06006BA5 RID: 27557 RVA: 0x0009AE26 File Offset: 0x00099026
		public unsafe bool bRaiseMaxErrorToExisting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bRaiseMaxErrorToExisting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bRaiseMaxErrorToExisting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06006BA6 RID: 27558 RVA: 0x0009AE37 File Offset: 0x00099037
		// (set) Token: 0x06006BA7 RID: 27559 RVA: 0x0009AE47 File Offset: 0x00099047
		public unsafe bool bEnablePerformanceLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bEnablePerformanceLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bEnablePerformanceLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x0009AE58 File Offset: 0x00099058
		// (set) Token: 0x06006BA9 RID: 27561 RVA: 0x0009AE68 File Offset: 0x00099068
		public unsafe bool bStripAnimationDataOnDedicatedServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bStripAnimationDataOnDedicatedServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bStripAnimationDataOnDedicatedServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06006BAA RID: 27562 RVA: 0x0009AE79 File Offset: 0x00099079
		// (set) Token: 0x06006BAB RID: 27563 RVA: 0x0009AE89 File Offset: 0x00099089
		public unsafe bool bTickAnimationOnSkeletalMeshInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bTickAnimationOnSkeletalMeshInit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bTickAnimationOnSkeletalMeshInit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x0009AE9C File Offset: 0x0009909C
		// (set) Token: 0x06006BAD RID: 27565 RVA: 0x0009AED5 File Offset: 0x000990D5
		public TArray<FCustomAttributeSetting> BoneCustomAttributesNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomAttributeSetting> result;
				if ((result = this._BoneCustomAttributesNames) == null)
				{
					result = (this._BoneCustomAttributesNames = new TArray<FCustomAttributeSetting>(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_BoneCustomAttributesNames, this));
				}
				return result;
			}
			set
			{
				this.BoneCustomAttributesNames.CopyAssign(value);
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06006BAE RID: 27566 RVA: 0x0009AEE4 File Offset: 0x000990E4
		// (set) Token: 0x06006BAF RID: 27567 RVA: 0x0009AF1D File Offset: 0x0009911D
		public TArray<string> BoneNamesWithCustomAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BoneNamesWithCustomAttributes) == null)
				{
					result = (this._BoneNamesWithCustomAttributes = new TArray<string>(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_BoneNamesWithCustomAttributes, this));
				}
				return result;
			}
			set
			{
				this.BoneNamesWithCustomAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06006BB0 RID: 27568 RVA: 0x0009AF2C File Offset: 0x0009912C
		// (set) Token: 0x06006BB1 RID: 27569 RVA: 0x0009AF65 File Offset: 0x00099165
		public TMap<FName, ECustomAttributeBlendType> AttributeBlendModes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, ECustomAttributeBlendType> result;
				if ((result = this._AttributeBlendModes) == null)
				{
					result = (this._AttributeBlendModes = new TMap<FName, ECustomAttributeBlendType>(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_AttributeBlendModes, this));
				}
				return result;
			}
			set
			{
				this.AttributeBlendModes.CopyAssign(value);
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06006BB2 RID: 27570 RVA: 0x0009AF73 File Offset: 0x00099173
		// (set) Token: 0x06006BB3 RID: 27571 RVA: 0x0009AF83 File Offset: 0x00099183
		public unsafe ECustomAttributeBlendType DefaultAttributeBlendMode
		{
			get
			{
				return (ECustomAttributeBlendType)(*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_DefaultAttributeBlendMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_DefaultAttributeBlendMode) = (byte)value;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x0009AF94 File Offset: 0x00099194
		// (set) Token: 0x06006BB5 RID: 27573 RVA: 0x0009AFA4 File Offset: 0x000991A4
		public unsafe bool bEnableAutoImportSkeletalMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bEnableAutoImportSkeletalMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationSettings.__PropertyOffset_bEnableAutoImportSkeletalMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x0009AFB5 File Offset: 0x000991B5
		static UAnimationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimationSettings");
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x0009AFC3 File Offset: 0x000991C3
		protected UAnimationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033C2 RID: 13250
		public new const string __ObjectPath = "/Script/Engine.AnimationSettings";

		// Token: 0x040033C3 RID: 13251
		private static IntPtr _ClassPtr;

		// Token: 0x040033C4 RID: 13252
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033C5 RID: 13253
		internal static int __PropertyOffset_CompressCommandletVersion;

		// Token: 0x040033C6 RID: 13254
		internal static int __PropertyOffset_KeyEndEffectorsMatchNameArray;

		// Token: 0x040033C7 RID: 13255
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _KeyEndEffectorsMatchNameArray;

		// Token: 0x040033C8 RID: 13256
		internal static int __PropertyOffset_ForceRecompression;

		// Token: 0x040033C9 RID: 13257
		internal static int __PropertyOffset_bForceBelowThreshold;

		// Token: 0x040033CA RID: 13258
		internal static int __PropertyOffset_bFirstRecompressUsingCurrentOrDefault;

		// Token: 0x040033CB RID: 13259
		internal static int __PropertyOffset_bRaiseMaxErrorToExisting;

		// Token: 0x040033CC RID: 13260
		internal static int __PropertyOffset_bEnablePerformanceLog;

		// Token: 0x040033CD RID: 13261
		internal static int __PropertyOffset_bStripAnimationDataOnDedicatedServer;

		// Token: 0x040033CE RID: 13262
		internal static int __PropertyOffset_bTickAnimationOnSkeletalMeshInit;

		// Token: 0x040033CF RID: 13263
		internal static int __PropertyOffset_BoneCustomAttributesNames;

		// Token: 0x040033D0 RID: 13264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomAttributeSetting> _BoneCustomAttributesNames;

		// Token: 0x040033D1 RID: 13265
		internal static int __PropertyOffset_BoneNamesWithCustomAttributes;

		// Token: 0x040033D2 RID: 13266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BoneNamesWithCustomAttributes;

		// Token: 0x040033D3 RID: 13267
		internal static int __PropertyOffset_AttributeBlendModes;

		// Token: 0x040033D4 RID: 13268
		[Nullable(2)]
		private TMap<FName, ECustomAttributeBlendType> _AttributeBlendModes;

		// Token: 0x040033D5 RID: 13269
		internal static int __PropertyOffset_DefaultAttributeBlendMode;

		// Token: 0x040033D6 RID: 13270
		internal static int __PropertyOffset_bEnableAutoImportSkeletalMesh;
	}
}
