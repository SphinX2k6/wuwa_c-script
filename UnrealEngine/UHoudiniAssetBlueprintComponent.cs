using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A1 RID: 5281
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintComponent")]
	[UnrealStructLayout(3168, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3168)]
	public class UHoudiniAssetBlueprintComponent : UHoudiniAssetComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060131EC RID: 78316 RVA: 0x001C1F4F File Offset: 0x001C014F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetBlueprintComponent._ClassPtr;
		}

		// Token: 0x060131ED RID: 78317 RVA: 0x001C1F5C File Offset: 0x001C015C
		public UHoudiniAssetBlueprintComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetBlueprintComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060131EE RID: 78318 RVA: 0x001C1F84 File Offset: 0x001C0184
		public UHoudiniAssetBlueprintComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetBlueprintComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x060131EF RID: 78319 RVA: 0x001C1FB7 File Offset: 0x001C01B7
		// (set) Token: 0x060131F0 RID: 78320 RVA: 0x001C1FC7 File Offset: 0x001C01C7
		public unsafe bool FauxBPProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_FauxBPProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_FauxBPProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x060131F1 RID: 78321 RVA: 0x001C1FD8 File Offset: 0x001C01D8
		// (set) Token: 0x060131F2 RID: 78322 RVA: 0x001C1FE8 File Offset: 0x001C01E8
		public unsafe bool bHoudiniAssetChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bHoudiniAssetChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bHoudiniAssetChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x060131F3 RID: 78323 RVA: 0x001C1FF9 File Offset: 0x001C01F9
		// (set) Token: 0x060131F4 RID: 78324 RVA: 0x001C2009 File Offset: 0x001C0209
		public unsafe bool bUpdatedFromTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bUpdatedFromTemplate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bUpdatedFromTemplate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x060131F5 RID: 78325 RVA: 0x001C201A File Offset: 0x001C021A
		// (set) Token: 0x060131F6 RID: 78326 RVA: 0x001C202A File Offset: 0x001C022A
		public unsafe bool bIsInBlueprintEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bIsInBlueprintEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bIsInBlueprintEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x060131F7 RID: 78327 RVA: 0x001C203B File Offset: 0x001C023B
		// (set) Token: 0x060131F8 RID: 78328 RVA: 0x001C204B File Offset: 0x001C024B
		public unsafe bool bCanDeleteHoudiniNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bCanDeleteHoudiniNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bCanDeleteHoudiniNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x060131F9 RID: 78329 RVA: 0x001C205C File Offset: 0x001C025C
		// (set) Token: 0x060131FA RID: 78330 RVA: 0x001C206C File Offset: 0x001C026C
		public unsafe bool bHasRegisteredComponentTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bHasRegisteredComponentTemplate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_bHasRegisteredComponentTemplate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x060131FB RID: 78331 RVA: 0x001C2080 File Offset: 0x001C0280
		// (set) Token: 0x060131FC RID: 78332 RVA: 0x001C20B9 File Offset: 0x001C02B9
		public TMap<FHoudiniOutputObjectIdentifier, FGuid> CachedOutputNodes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHoudiniOutputObjectIdentifier, FGuid> result;
				if ((result = this._CachedOutputNodes) == null)
				{
					result = (this._CachedOutputNodes = new TMap<FHoudiniOutputObjectIdentifier, FGuid>(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_CachedOutputNodes, this));
				}
				return result;
			}
			set
			{
				this.CachedOutputNodes.CopyAssign(value);
			}
		}

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x060131FD RID: 78333 RVA: 0x001C20C8 File Offset: 0x001C02C8
		// (set) Token: 0x060131FE RID: 78334 RVA: 0x001C2101 File Offset: 0x001C0301
		public TMap<FGuid, FGuid> CachedInputNodes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._CachedInputNodes) == null)
				{
					result = (this._CachedInputNodes = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)UHoudiniAssetBlueprintComponent.__PropertyOffset_CachedInputNodes, this));
				}
				return result;
			}
			set
			{
				this.CachedInputNodes.CopyAssign(value);
			}
		}

		// Token: 0x060131FF RID: 78335 RVA: 0x001C2110 File Offset: 0x001C0310
		public unsafe void SetToggleValueAt(string Name, bool Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Name);
			UHoudiniAssetBlueprintComponent.__SetToggleValueAt_Internal(base.NativePtr, fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06013200 RID: 78336 RVA: 0x001C213C File Offset: 0x001C033C
		public unsafe void SetFloatParameter(string Name, float Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Name);
			UHoudiniAssetBlueprintComponent.__SetFloatParameter_Internal(base.NativePtr, fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06013201 RID: 78337 RVA: 0x001C2168 File Offset: 0x001C0368
		public unsafe bool HasParameter(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			bool result = UHoudiniAssetBlueprintComponent.__HasParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06013202 RID: 78338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleValueAt_Internal(IntPtr @this, in FString Name, bool Value, int Index);

		// Token: 0x06013203 RID: 78339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, in FString Name, float Value, int Index);

		// Token: 0x06013204 RID: 78340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasParameter_Internal(IntPtr @this, in FString Name);

		// Token: 0x06013205 RID: 78341 RVA: 0x001C2192 File Offset: 0x001C0392
		static UHoudiniAssetBlueprintComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintComponent");
		}

		// Token: 0x06013206 RID: 78342 RVA: 0x001C21A0 File Offset: 0x001C03A0
		protected UHoudiniAssetBlueprintComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A529 RID: 42281
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintComponent";

		// Token: 0x0400A52A RID: 42282
		private static IntPtr _ClassPtr;

		// Token: 0x0400A52B RID: 42283
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A52C RID: 42284
		internal static int __PropertyOffset_FauxBPProperty;

		// Token: 0x0400A52D RID: 42285
		internal static int __PropertyOffset_bHoudiniAssetChanged;

		// Token: 0x0400A52E RID: 42286
		internal static int __PropertyOffset_bUpdatedFromTemplate;

		// Token: 0x0400A52F RID: 42287
		internal static int __PropertyOffset_bIsInBlueprintEditor;

		// Token: 0x0400A530 RID: 42288
		internal static int __PropertyOffset_bCanDeleteHoudiniNodes;

		// Token: 0x0400A531 RID: 42289
		internal static int __PropertyOffset_bHasRegisteredComponentTemplate;

		// Token: 0x0400A532 RID: 42290
		internal static int __PropertyOffset_CachedOutputNodes;

		// Token: 0x0400A533 RID: 42291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FHoudiniOutputObjectIdentifier, FGuid> _CachedOutputNodes;

		// Token: 0x0400A534 RID: 42292
		internal static int __PropertyOffset_CachedInputNodes;

		// Token: 0x0400A535 RID: 42293
		[Nullable(2)]
		private TMap<FGuid, FGuid> _CachedInputNodes;
	}
}
