using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D27 RID: 3367
	[UnrealObjectPath("/Script/Engine.LevelInstance")]
	[UnrealStructLayout(1400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1400)]
	public class ALevelInstance : AActor, IUnrealUObject, IUnrealObject, ILevelInstanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B4A6 RID: 46246 RVA: 0x00101A4A File Offset: 0x000FFC4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelInstance._ClassPtr;
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x00101A56 File Offset: 0x000FFC56
		int ILevelInstanceInterface.InterfaceOffset()
		{
			return ALevelInstance.__InterfaceOffset_ILevelInstanceInterface;
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x00101A60 File Offset: 0x000FFC60
		public ALevelInstance() : this(BuiltinUtils.AllocNativeUObject(ALevelInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x00101A88 File Offset: 0x000FFC88
		[NullableContext(1)]
		public ALevelInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x0600B4AA RID: 46250 RVA: 0x00101ABB File Offset: 0x000FFCBB
		// (set) Token: 0x0600B4AB RID: 46251 RVA: 0x00101AD0 File Offset: 0x000FFCD0
		[Nullable(1)]
		public TSoftObjectPtr<UWorld> CookedWorldAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)ALevelInstance.__PropertyOffset_CookedWorldAsset, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ALevelInstance.__PropertyOffset_CookedWorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x0600B4AC RID: 46252 RVA: 0x00101AF5 File Offset: 0x000FFCF5
		// (set) Token: 0x0600B4AD RID: 46253 RVA: 0x00101B05 File Offset: 0x000FFD05
		public unsafe bool bIsWPLevelInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALevelInstance.__PropertyOffset_bIsWPLevelInstance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALevelInstance.__PropertyOffset_bIsWPLevelInstance) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x00101B16 File Offset: 0x000FFD16
		static ALevelInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstance");
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x00101B24 File Offset: 0x000FFD24
		protected ALevelInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005EF7 RID: 24311
		internal static int __InterfaceOffset_ILevelInstanceInterface;

		// Token: 0x04005EF8 RID: 24312
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstance";

		// Token: 0x04005EF9 RID: 24313
		private static IntPtr _ClassPtr;

		// Token: 0x04005EFA RID: 24314
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005EFB RID: 24315
		internal static int __PropertyOffset_CookedWorldAsset;

		// Token: 0x04005EFC RID: 24316
		internal static int __PropertyOffset_bIsWPLevelInstance;
	}
}
