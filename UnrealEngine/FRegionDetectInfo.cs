using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001768 RID: 5992
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.RegionDetectInfo")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRegionDetectInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060158D8 RID: 88280 RVA: 0x001FB602 File Offset: 0x001F9802
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegionDetectInfo._ScriptStructPtr != 0) ? FRegionDetectInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.RegionDetectInfo", ref FRegionDetectInfo._ScriptStructPtr);
		}

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x060158D9 RID: 88281 RVA: 0x001FB628 File Offset: 0x001F9828
		// (set) Token: 0x060158DA RID: 88282 RVA: 0x001FB66B File Offset: 0x001F986B
		public TMap<string, UKuroRegionEventBinder> RegionEventMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UKuroRegionEventBinder> result;
				if ((result = this._RegionEventMap) == null)
				{
					result = (this._RegionEventMap = new TMap<string, UKuroRegionEventBinder>(base.NativePtr + (IntPtr)FRegionDetectInfo.__PropertyOffset_RegionEventMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RegionEventMap.CopyAssign(value);
			}
		}

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x060158DB RID: 88283 RVA: 0x001FB67C File Offset: 0x001F987C
		// (set) Token: 0x060158DC RID: 88284 RVA: 0x001FB6BF File Offset: 0x001F98BF
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> EventTargets
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._EventTargets) == null)
				{
					result = (this._EventTargets = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)FRegionDetectInfo.__PropertyOffset_EventTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.EventTargets.CopyAssign(value);
			}
		}

		// Token: 0x060158DD RID: 88285 RVA: 0x001FB6CD File Offset: 0x001F98CD
		public FRegionDetectInfo()
		{
		}

		// Token: 0x060158DE RID: 88286 RVA: 0x001FB6D5 File Offset: 0x001F98D5
		public FRegionDetectInfo(TMap<string, UKuroRegionEventBinder> RegionEventMap, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<AActor>> EventTargets)
		{
			this.RegionEventMap = RegionEventMap;
			this.EventTargets = EventTargets;
		}

		// Token: 0x060158DF RID: 88287 RVA: 0x001FB6EB File Offset: 0x001F98EB
		protected override IntPtr GetUStructPtr()
		{
			return FRegionDetectInfo.StaticStruct();
		}

		// Token: 0x060158E0 RID: 88288 RVA: 0x001FB6F7 File Offset: 0x001F98F7
		[NullableContext(2)]
		public FRegionDetectInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158E1 RID: 88289 RVA: 0x001FB701 File Offset: 0x001F9901
		public FRegionDetectInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x001FB70C File Offset: 0x001F990C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegionDetectInfo(Pointer, false, true);
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x001FB716 File Offset: 0x001F9916
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegionDetectInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC31 RID: 48177
		public const string __ObjectPath = "/Script/KuroComponent.RegionDetectInfo";

		// Token: 0x0400BC32 RID: 48178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC33 RID: 48179
		internal static int __PropertyOffset_RegionEventMap;

		// Token: 0x0400BC34 RID: 48180
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroRegionEventBinder> _RegionEventMap;

		// Token: 0x0400BC35 RID: 48181
		internal static int __PropertyOffset_EventTargets;

		// Token: 0x0400BC36 RID: 48182
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _EventTargets;
	}
}
