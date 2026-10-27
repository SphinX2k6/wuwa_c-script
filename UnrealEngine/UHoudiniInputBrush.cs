using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CB RID: 5323
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputBrush")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UHoudiniInputBrush : UHoudiniInputActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134C9 RID: 79049 RVA: 0x001C60B4 File Offset: 0x001C42B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputBrush._ClassPtr;
		}

		// Token: 0x060134CA RID: 79050 RVA: 0x001C60C0 File Offset: 0x001C42C0
		public UHoudiniInputBrush() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputBrush.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134CB RID: 79051 RVA: 0x001C60E8 File Offset: 0x001C42E8
		[NullableContext(1)]
		public UHoudiniInputBrush(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputBrush.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x060134CC RID: 79052 RVA: 0x001C611C File Offset: 0x001C431C
		// (set) Token: 0x060134CD RID: 79053 RVA: 0x001C6155 File Offset: 0x001C4355
		[Nullable(1)]
		public TArray<FHoudiniBrushInfo> BrushesInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FHoudiniBrushInfo> result;
				if ((result = this._BrushesInfo) == null)
				{
					result = (this._BrushesInfo = new TArray<FHoudiniBrushInfo>(base.NativePtr + (IntPtr)UHoudiniInputBrush.__PropertyOffset_BrushesInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BrushesInfo.CopyAssign(value);
			}
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x060134CE RID: 79054 RVA: 0x001C6163 File Offset: 0x001C4363
		// (set) Token: 0x060134CF RID: 79055 RVA: 0x001C6177 File Offset: 0x001C4377
		[Nullable(2)]
		public unsafe UModel CombinedModel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UModel>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInputBrush.__PropertyOffset_CombinedModel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInputBrush.__PropertyOffset_CombinedModel, value);
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x060134D0 RID: 79056 RVA: 0x001C618C File Offset: 0x001C438C
		// (set) Token: 0x060134D1 RID: 79057 RVA: 0x001C619C File Offset: 0x001C439C
		public unsafe bool bIgnoreInputObject
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputBrush.__PropertyOffset_bIgnoreInputObject) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputBrush.__PropertyOffset_bIgnoreInputObject) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x060134D2 RID: 79058 RVA: 0x001C61AD File Offset: 0x001C43AD
		// (set) Token: 0x060134D3 RID: 79059 RVA: 0x001C61C1 File Offset: 0x001C43C1
		public unsafe TEnumAsByte<EBrushType> CachedInputBrushType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputBrush.__PropertyOffset_CachedInputBrushType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputBrush.__PropertyOffset_CachedInputBrushType) = value;
			}
		}

		// Token: 0x060134D4 RID: 79060 RVA: 0x001C61D6 File Offset: 0x001C43D6
		static UHoudiniInputBrush()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputBrush");
		}

		// Token: 0x060134D5 RID: 79061 RVA: 0x001C61E4 File Offset: 0x001C43E4
		protected UHoudiniInputBrush(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6C8 RID: 42696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputBrush";

		// Token: 0x0400A6C9 RID: 42697
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6CA RID: 42698
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6CB RID: 42699
		internal static int __PropertyOffset_BrushesInfo;

		// Token: 0x0400A6CC RID: 42700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHoudiniBrushInfo> _BrushesInfo;

		// Token: 0x0400A6CD RID: 42701
		internal static int __PropertyOffset_CombinedModel;

		// Token: 0x0400A6CE RID: 42702
		internal static int __PropertyOffset_bIgnoreInputObject;

		// Token: 0x0400A6CF RID: 42703
		internal static int __PropertyOffset_CachedInputBrushType;
	}
}
