using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028BE RID: 10430
	[UnrealObjectPath("/Script/StandinActor.StandinLightmapSettings")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FStandinLightmapSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026BB0 RID: 158640 RVA: 0x003B15E9 File Offset: 0x003AF7E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStandinLightmapSettings._ScriptStructPtr != 0) ? FStandinLightmapSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StandinActor.StandinLightmapSettings", ref FStandinLightmapSettings._ScriptStructPtr);
		}

		// Token: 0x1700953B RID: 38203
		// (get) Token: 0x06026BB1 RID: 158641 RVA: 0x003B160D File Offset: 0x003AF80D
		// (set) Token: 0x06026BB2 RID: 158642 RVA: 0x003B161D File Offset: 0x003AF81D
		public unsafe int LightmapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStandinLightmapSettings.__PropertyOffset_LightmapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStandinLightmapSettings.__PropertyOffset_LightmapResolution) = value;
			}
		}

		// Token: 0x1700953C RID: 38204
		// (get) Token: 0x06026BB3 RID: 158643 RVA: 0x003B162E File Offset: 0x003AF82E
		// (set) Token: 0x06026BB4 RID: 158644 RVA: 0x003B163E File Offset: 0x003AF83E
		public unsafe int LightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStandinLightmapSettings.__PropertyOffset_LightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStandinLightmapSettings.__PropertyOffset_LightmapIndex) = value;
			}
		}

		// Token: 0x06026BB5 RID: 158645 RVA: 0x003B164F File Offset: 0x003AF84F
		public FStandinLightmapSettings()
		{
		}

		// Token: 0x06026BB6 RID: 158646 RVA: 0x003B1657 File Offset: 0x003AF857
		public FStandinLightmapSettings(int LightmapResolution, int LightmapIndex)
		{
			this.LightmapResolution = LightmapResolution;
			this.LightmapIndex = LightmapIndex;
		}

		// Token: 0x06026BB7 RID: 158647 RVA: 0x003B166D File Offset: 0x003AF86D
		protected override IntPtr GetUStructPtr()
		{
			return FStandinLightmapSettings.StaticStruct();
		}

		// Token: 0x06026BB8 RID: 158648 RVA: 0x003B1679 File Offset: 0x003AF879
		[NullableContext(2)]
		public FStandinLightmapSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026BB9 RID: 158649 RVA: 0x003B1683 File Offset: 0x003AF883
		public FStandinLightmapSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026BBA RID: 158650 RVA: 0x003B168E File Offset: 0x003AF88E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStandinLightmapSettings(Pointer, false, true);
		}

		// Token: 0x06026BBB RID: 158651 RVA: 0x003B1698 File Offset: 0x003AF898
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStandinLightmapSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04015413 RID: 87059
		[Nullable(1)]
		public const string __ObjectPath = "/Script/StandinActor.StandinLightmapSettings";

		// Token: 0x04015414 RID: 87060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015415 RID: 87061
		internal static int __PropertyOffset_LightmapResolution;

		// Token: 0x04015416 RID: 87062
		internal static int __PropertyOffset_LightmapIndex;
	}
}
