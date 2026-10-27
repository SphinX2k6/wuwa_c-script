using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCB RID: 7115
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareManager")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroSunLensflareManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B4DA RID: 111834 RVA: 0x00283A98 File Offset: 0x00281C98
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSunLensflareManager._ScriptStructPtr != 0) ? FKuroSunLensflareManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareManager", ref FKuroSunLensflareManager._ScriptStructPtr);
		}

		// Token: 0x17006DB1 RID: 28081
		// (get) Token: 0x0601B4DB RID: 111835 RVA: 0x00283ABC File Offset: 0x00281CBC
		// (set) Token: 0x0601B4DC RID: 111836 RVA: 0x00283AFF File Offset: 0x00281CFF
		[Nullable(1)]
		public FKuroSunLensflareInfo CurrentInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroSunLensflareInfo result;
				if ((result = this._CurrentInfo) == null)
				{
					result = (this._CurrentInfo = new FKuroSunLensflareInfo(base.NativePtr + (IntPtr)FKuroSunLensflareManager.__PropertyOffset_CurrentInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSunLensflareInfo.StaticStruct(), base.NativePtr + (IntPtr)FKuroSunLensflareManager.__PropertyOffset_CurrentInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006DB2 RID: 28082
		// (get) Token: 0x0601B4DD RID: 111837 RVA: 0x00283B20 File Offset: 0x00281D20
		// (set) Token: 0x0601B4DE RID: 111838 RVA: 0x00283B34 File Offset: 0x00281D34
		public unsafe UWorld CachedWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareManager.__PropertyOffset_CachedWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareManager.__PropertyOffset_CachedWorld, value);
			}
		}

		// Token: 0x17006DB3 RID: 28083
		// (get) Token: 0x0601B4DF RID: 111839 RVA: 0x00283B49 File Offset: 0x00281D49
		// (set) Token: 0x0601B4E0 RID: 111840 RVA: 0x00283B5D File Offset: 0x00281D5D
		public unsafe UKuroGISystem CachedGISystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGISystem>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareManager.__PropertyOffset_CachedGISystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareManager.__PropertyOffset_CachedGISystem, value);
			}
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x00283B72 File Offset: 0x00281D72
		public FKuroSunLensflareManager()
		{
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x00283B7A File Offset: 0x00281D7A
		[NullableContext(1)]
		public FKuroSunLensflareManager(FKuroSunLensflareInfo CurrentInfo, UWorld CachedWorld, UKuroGISystem CachedGISystem)
		{
			this.CurrentInfo = CurrentInfo;
			this.CachedWorld = CachedWorld;
			this.CachedGISystem = CachedGISystem;
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x00283B97 File Offset: 0x00281D97
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSunLensflareManager.StaticStruct();
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x00283BA3 File Offset: 0x00281DA3
		public FKuroSunLensflareManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B4E5 RID: 111845 RVA: 0x00283BAD File Offset: 0x00281DAD
		public FKuroSunLensflareManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x00283BB8 File Offset: 0x00281DB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSunLensflareManager(Pointer, false, true);
		}

		// Token: 0x0601B4E7 RID: 111847 RVA: 0x00283BC2 File Offset: 0x00281DC2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSunLensflareManager(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB3C RID: 60220
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareManager";

		// Token: 0x0400EB3D RID: 60221
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB3E RID: 60222
		internal static int __PropertyOffset_CurrentInfo;

		// Token: 0x0400EB3F RID: 60223
		private FKuroSunLensflareInfo _CurrentInfo;

		// Token: 0x0400EB40 RID: 60224
		internal static int __PropertyOffset_CachedWorld;

		// Token: 0x0400EB41 RID: 60225
		internal static int __PropertyOffset_CachedGISystem;
	}
}
