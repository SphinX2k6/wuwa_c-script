using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BDC RID: 3036
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FlowMapSVT")]
	[UnrealStructLayout(4192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4192)]
	public class UFlowMapSVT : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600953D RID: 38205 RVA: 0x000D4E9C File Offset: 0x000D309C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFlowMapSVT._ClassPtr;
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x000D4EA8 File Offset: 0x000D30A8
		public UFlowMapSVT() : this(BuiltinUtils.AllocNativeUObject(UFlowMapSVT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x000D4ED0 File Offset: 0x000D30D0
		public UFlowMapSVT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFlowMapSVT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x06009540 RID: 38208 RVA: 0x000D4F03 File Offset: 0x000D3103
		// (set) Token: 0x06009541 RID: 38209 RVA: 0x000D4F13 File Offset: 0x000D3113
		public unsafe bool bBuiltDataDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_bBuiltDataDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_bBuiltDataDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x000D4F24 File Offset: 0x000D3124
		// (set) Token: 0x06009543 RID: 38211 RVA: 0x000D4F34 File Offset: 0x000D3134
		public unsafe int BuiltNumMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltNumMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltNumMips) = value;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x000D4F45 File Offset: 0x000D3145
		// (set) Token: 0x06009545 RID: 38213 RVA: 0x000D4F55 File Offset: 0x000D3155
		public unsafe int BuiltAddressCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltAddressCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltAddressCount) = value;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x000D4F66 File Offset: 0x000D3166
		// (set) Token: 0x06009547 RID: 38215 RVA: 0x000D4F76 File Offset: 0x000D3176
		public unsafe int BuiltStoredTileCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltStoredTileCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFlowMapSVT.__PropertyOffset_BuiltStoredTileCount) = value;
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x000D4F87 File Offset: 0x000D3187
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x000D4F9B File Offset: 0x000D319B
		public unsafe string LastBuildMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UFlowMapSVT.__PropertyOffset_LastBuildMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UFlowMapSVT.__PropertyOffset_LastBuildMessage)), value);
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600954A RID: 38218 RVA: 0x000D4FB0 File Offset: 0x000D31B0
		// (set) Token: 0x0600954B RID: 38219 RVA: 0x000D4FC4 File Offset: 0x000D31C4
		public unsafe string LastValidationMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UFlowMapSVT.__PropertyOffset_LastValidationMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UFlowMapSVT.__PropertyOffset_LastValidationMessage)), value);
			}
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x000D4FD9 File Offset: 0x000D31D9
		public void ValidateFlowMapSVT()
		{
			UFlowMapSVT.__ValidateFlowMapSVT_Internal(base.NativePtr);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x000D4FE6 File Offset: 0x000D31E6
		public void DumpFlowMapSVTMemory()
		{
			UFlowMapSVT.__DumpFlowMapSVTMemory_Internal(base.NativePtr);
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x000D4FF3 File Offset: 0x000D31F3
		public void BuildFlowMapSVT()
		{
			UFlowMapSVT.__BuildFlowMapSVT_Internal(base.NativePtr);
		}

		// Token: 0x0600954F RID: 38223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ValidateFlowMapSVT_Internal(IntPtr @this);

		// Token: 0x06009550 RID: 38224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpFlowMapSVTMemory_Internal(IntPtr @this);

		// Token: 0x06009551 RID: 38225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildFlowMapSVT_Internal(IntPtr @this);

		// Token: 0x06009552 RID: 38226 RVA: 0x000D5000 File Offset: 0x000D3200
		static UFlowMapSVT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FlowMapSVT");
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x000D500E File Offset: 0x000D320E
		protected UFlowMapSVT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053C1 RID: 21441
		public new const string __ObjectPath = "/Script/Engine.FlowMapSVT";

		// Token: 0x040053C2 RID: 21442
		private static IntPtr _ClassPtr;

		// Token: 0x040053C3 RID: 21443
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053C4 RID: 21444
		internal static int __PropertyOffset_bBuiltDataDirty;

		// Token: 0x040053C5 RID: 21445
		internal static int __PropertyOffset_BuiltNumMips;

		// Token: 0x040053C6 RID: 21446
		internal static int __PropertyOffset_BuiltAddressCount;

		// Token: 0x040053C7 RID: 21447
		internal static int __PropertyOffset_BuiltStoredTileCount;

		// Token: 0x040053C8 RID: 21448
		internal static int __PropertyOffset_LastBuildMessage;

		// Token: 0x040053C9 RID: 21449
		internal static int __PropertyOffset_LastValidationMessage;
	}
}
