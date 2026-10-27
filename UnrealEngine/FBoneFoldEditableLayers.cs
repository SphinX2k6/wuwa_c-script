using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D2 RID: 2258
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneFoldEditableLayers")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBoneFoldEditableLayers : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C40 RID: 31808 RVA: 0x000B23F2 File Offset: 0x000B05F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFoldEditableLayers._ScriptStructPtr != 0) ? FBoneFoldEditableLayers._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneFoldEditableLayers", ref FBoneFoldEditableLayers._ScriptStructPtr);
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x000B2418 File Offset: 0x000B0618
		// (set) Token: 0x06007C42 RID: 31810 RVA: 0x000B245B File Offset: 0x000B065B
		public TArray<FBoneFoldLayer> BoneFoldLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneFoldLayer> result;
				if ((result = this._BoneFoldLayers) == null)
				{
					result = (this._BoneFoldLayers = new TArray<FBoneFoldLayer>(base.NativePtr + (IntPtr)FBoneFoldEditableLayers.__PropertyOffset_BoneFoldLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneFoldLayers.CopyAssign(value);
			}
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x000B2469 File Offset: 0x000B0669
		public FBoneFoldEditableLayers()
		{
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x000B2471 File Offset: 0x000B0671
		public FBoneFoldEditableLayers(TArray<FBoneFoldLayer> BoneFoldLayers)
		{
			this.BoneFoldLayers = BoneFoldLayers;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x000B2480 File Offset: 0x000B0680
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFoldEditableLayers.StaticStruct();
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x000B248C File Offset: 0x000B068C
		[NullableContext(2)]
		public FBoneFoldEditableLayers(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x000B2496 File Offset: 0x000B0696
		public FBoneFoldEditableLayers(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x000B24A1 File Offset: 0x000B06A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFoldEditableLayers(Pointer, false, true);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x000B24AB File Offset: 0x000B06AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFoldEditableLayers(Pointer, MemoryOwner);
		}

		// Token: 0x04003B91 RID: 15249
		public const string __ObjectPath = "/Script/Engine.BoneFoldEditableLayers";

		// Token: 0x04003B92 RID: 15250
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B93 RID: 15251
		internal static int __PropertyOffset_BoneFoldLayers;

		// Token: 0x04003B94 RID: 15252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneFoldLayer> _BoneFoldLayers;
	}
}
