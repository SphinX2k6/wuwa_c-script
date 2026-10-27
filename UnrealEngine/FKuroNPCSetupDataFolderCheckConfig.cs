using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CFE RID: 3326
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroNPCSetupDataFolderCheckConfig")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroNPCSetupDataFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B11D RID: 45341 RVA: 0x000FB812 File Offset: 0x000F9A12
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNPCSetupDataFolderCheckConfig._ScriptStructPtr != 0) ? FKuroNPCSetupDataFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroNPCSetupDataFolderCheckConfig", ref FKuroNPCSetupDataFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x000FB836 File Offset: 0x000F9A36
		// (set) Token: 0x0600B11F RID: 45343 RVA: 0x000FB84A File Offset: 0x000F9A4A
		public unsafe string SkelMainSuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelMainSuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelMainSuffix)), value);
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600B120 RID: 45344 RVA: 0x000FB85F File Offset: 0x000F9A5F
		// (set) Token: 0x0600B121 RID: 45345 RVA: 0x000FB873 File Offset: 0x000F9A73
		public unsafe string SkelHairSuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelHairSuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelHairSuffix)), value);
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600B122 RID: 45346 RVA: 0x000FB888 File Offset: 0x000F9A88
		// (set) Token: 0x0600B123 RID: 45347 RVA: 0x000FB89C File Offset: 0x000F9A9C
		public unsafe string SkelFaceSuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelFaceSuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelFaceSuffix)), value);
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600B124 RID: 45348 RVA: 0x000FB8B1 File Offset: 0x000F9AB1
		// (set) Token: 0x0600B125 RID: 45349 RVA: 0x000FB8C5 File Offset: 0x000F9AC5
		public unsafe string SkelBodySuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelBodySuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNPCSetupDataFolderCheckConfig.__PropertyOffset_SkelBodySuffix)), value);
			}
		}

		// Token: 0x0600B126 RID: 45350 RVA: 0x000FB8DA File Offset: 0x000F9ADA
		public FKuroNPCSetupDataFolderCheckConfig()
		{
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x000FB8E2 File Offset: 0x000F9AE2
		public FKuroNPCSetupDataFolderCheckConfig(string SkelMainSuffix, string SkelHairSuffix, string SkelFaceSuffix, string SkelBodySuffix, string Regex, int MatchingPriority)
		{
			this.SkelMainSuffix = SkelMainSuffix;
			this.SkelHairSuffix = SkelHairSuffix;
			this.SkelFaceSuffix = SkelFaceSuffix;
			this.SkelBodySuffix = SkelBodySuffix;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x000FB917 File Offset: 0x000F9B17
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNPCSetupDataFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x000FB923 File Offset: 0x000F9B23
		[NullableContext(2)]
		public FKuroNPCSetupDataFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x000FB92D File Offset: 0x000F9B2D
		public FKuroNPCSetupDataFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x000FB938 File Offset: 0x000F9B38
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNPCSetupDataFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x000FB942 File Offset: 0x000F9B42
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNPCSetupDataFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005CCE RID: 23758
		public new const string __ObjectPath = "/Script/Engine.KuroNPCSetupDataFolderCheckConfig";

		// Token: 0x04005CCF RID: 23759
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CD0 RID: 23760
		internal static int __PropertyOffset_SkelMainSuffix;

		// Token: 0x04005CD1 RID: 23761
		internal static int __PropertyOffset_SkelHairSuffix;

		// Token: 0x04005CD2 RID: 23762
		internal static int __PropertyOffset_SkelFaceSuffix;

		// Token: 0x04005CD3 RID: 23763
		internal static int __PropertyOffset_SkelBodySuffix;
	}
}
