using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027E4 RID: 10212
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.VertexWeightSettings")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FVertexWeightSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602611B RID: 155931 RVA: 0x0039BDD4 File Offset: 0x00399FD4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexWeightSettings._ScriptStructPtr != 0) ? FVertexWeightSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.VertexWeightSettings", ref FVertexWeightSettings._ScriptStructPtr);
		}

		// Token: 0x170092E8 RID: 37608
		// (get) Token: 0x0602611C RID: 155932 RVA: 0x0039BDF8 File Offset: 0x00399FF8
		// (set) Token: 0x0602611D RID: 155933 RVA: 0x0039BE11 File Offset: 0x0039A011
		public unsafe bool UseVertexWeightsInReducer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInReducer) & FVertexWeightSettings.__PropertyMask_UseVertexWeightsInReducer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInReducer) = ((*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInReducer) & ~FVertexWeightSettings.__PropertyMask_UseVertexWeightsInReducer) | (value ? FVertexWeightSettings.__PropertyMask_UseVertexWeightsInReducer : 0));
			}
		}

		// Token: 0x170092E9 RID: 37609
		// (get) Token: 0x0602611E RID: 155934 RVA: 0x0039BE41 File Offset: 0x0039A041
		// (set) Token: 0x0602611F RID: 155935 RVA: 0x0039BE5A File Offset: 0x0039A05A
		public unsafe bool UseVertexWeightsInTexcoordGenerator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInTexcoordGenerator) & FVertexWeightSettings.__PropertyMask_UseVertexWeightsInTexcoordGenerator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInTexcoordGenerator) = ((*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_UseVertexWeightsInTexcoordGenerator) & ~FVertexWeightSettings.__PropertyMask_UseVertexWeightsInTexcoordGenerator) | (value ? FVertexWeightSettings.__PropertyMask_UseVertexWeightsInTexcoordGenerator : 0));
			}
		}

		// Token: 0x170092EA RID: 37610
		// (get) Token: 0x06026120 RID: 155936 RVA: 0x0039BE8A File Offset: 0x0039A08A
		// (set) Token: 0x06026121 RID: 155937 RVA: 0x0039BE9A File Offset: 0x0039A09A
		public unsafe int WeightsFromColorLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorLevel) = value;
			}
		}

		// Token: 0x170092EB RID: 37611
		// (get) Token: 0x06026122 RID: 155938 RVA: 0x0039BEAB File Offset: 0x0039A0AB
		// (set) Token: 0x06026123 RID: 155939 RVA: 0x0039BEBF File Offset: 0x0039A0BF
		public unsafe string WeightsFromColorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorName)), value);
			}
		}

		// Token: 0x170092EC RID: 37612
		// (get) Token: 0x06026124 RID: 155940 RVA: 0x0039BED4 File Offset: 0x0039A0D4
		// (set) Token: 0x06026125 RID: 155941 RVA: 0x0039BEE4 File Offset: 0x0039A0E4
		public unsafe EWeightsFromColorComponent WeightsFromColorComponent
		{
			get
			{
				return (EWeightsFromColorComponent)(*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorComponent) = (byte)value;
			}
		}

		// Token: 0x170092ED RID: 37613
		// (get) Token: 0x06026126 RID: 155942 RVA: 0x0039BEF5 File Offset: 0x0039A0F5
		// (set) Token: 0x06026127 RID: 155943 RVA: 0x0039BF05 File Offset: 0x0039A105
		public unsafe float WeightsFromColorMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorMultiplier) = value;
			}
		}

		// Token: 0x170092EE RID: 37614
		// (get) Token: 0x06026128 RID: 155944 RVA: 0x0039BF16 File Offset: 0x0039A116
		// (set) Token: 0x06026129 RID: 155945 RVA: 0x0039BF26 File Offset: 0x0039A126
		public unsafe EWeightsFromColorMode WeightsFromColorMode
		{
			get
			{
				return (EWeightsFromColorMode)(*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexWeightSettings.__PropertyOffset_WeightsFromColorMode) = (byte)value;
			}
		}

		// Token: 0x0602612A RID: 155946 RVA: 0x0039BF37 File Offset: 0x0039A137
		public FVertexWeightSettings()
		{
		}

		// Token: 0x0602612B RID: 155947 RVA: 0x0039BF3F File Offset: 0x0039A13F
		public FVertexWeightSettings(bool UseVertexWeightsInReducer, bool UseVertexWeightsInTexcoordGenerator, int WeightsFromColorLevel, string WeightsFromColorName, EWeightsFromColorComponent WeightsFromColorComponent, float WeightsFromColorMultiplier, EWeightsFromColorMode WeightsFromColorMode)
		{
			this.UseVertexWeightsInReducer = UseVertexWeightsInReducer;
			this.UseVertexWeightsInTexcoordGenerator = UseVertexWeightsInTexcoordGenerator;
			this.WeightsFromColorLevel = WeightsFromColorLevel;
			this.WeightsFromColorName = WeightsFromColorName;
			this.WeightsFromColorComponent = WeightsFromColorComponent;
			this.WeightsFromColorMultiplier = WeightsFromColorMultiplier;
			this.WeightsFromColorMode = WeightsFromColorMode;
		}

		// Token: 0x0602612C RID: 155948 RVA: 0x0039BF7C File Offset: 0x0039A17C
		protected override IntPtr GetUStructPtr()
		{
			return FVertexWeightSettings.StaticStruct();
		}

		// Token: 0x0602612D RID: 155949 RVA: 0x0039BF88 File Offset: 0x0039A188
		[NullableContext(2)]
		public FVertexWeightSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602612E RID: 155950 RVA: 0x0039BF92 File Offset: 0x0039A192
		public FVertexWeightSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602612F RID: 155951 RVA: 0x0039BF9D File Offset: 0x0039A19D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexWeightSettings(Pointer, false, true);
		}

		// Token: 0x06026130 RID: 155952 RVA: 0x0039BFA7 File Offset: 0x0039A1A7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexWeightSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C9C RID: 85148
		public const string __ObjectPath = "/Script/SimplygonUObjects.VertexWeightSettings";

		// Token: 0x04014C9D RID: 85149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C9E RID: 85150
		internal static int __PropertyOffset_UseVertexWeightsInReducer;

		// Token: 0x04014C9F RID: 85151
		internal static byte __PropertyMask_UseVertexWeightsInReducer;

		// Token: 0x04014CA0 RID: 85152
		internal static int __PropertyOffset_UseVertexWeightsInTexcoordGenerator;

		// Token: 0x04014CA1 RID: 85153
		internal static byte __PropertyMask_UseVertexWeightsInTexcoordGenerator;

		// Token: 0x04014CA2 RID: 85154
		internal static int __PropertyOffset_WeightsFromColorLevel;

		// Token: 0x04014CA3 RID: 85155
		internal static int __PropertyOffset_WeightsFromColorName;

		// Token: 0x04014CA4 RID: 85156
		internal static int __PropertyOffset_WeightsFromColorComponent;

		// Token: 0x04014CA5 RID: 85157
		internal static int __PropertyOffset_WeightsFromColorMultiplier;

		// Token: 0x04014CA6 RID: 85158
		internal static int __PropertyOffset_WeightsFromColorMode;
	}
}
