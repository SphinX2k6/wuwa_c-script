using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C2B RID: 3115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODBuildInputStats")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FHLODBuildInputStats : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E05 RID: 40453 RVA: 0x000E09C4 File Offset: 0x000DEBC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODBuildInputStats._ScriptStructPtr != 0) ? FHLODBuildInputStats._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODBuildInputStats", ref FHLODBuildInputStats._ScriptStructPtr);
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06009E06 RID: 40454 RVA: 0x000E09E8 File Offset: 0x000DEBE8
		// (set) Token: 0x06009E07 RID: 40455 RVA: 0x000E0A2B File Offset: 0x000DEC2B
		public TMap<FName, FHLODBuildInputReferencedAssets> BuildersReferencedAssets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FHLODBuildInputReferencedAssets> result;
				if ((result = this._BuildersReferencedAssets) == null)
				{
					result = (this._BuildersReferencedAssets = new TMap<FName, FHLODBuildInputReferencedAssets>(base.NativePtr + (IntPtr)FHLODBuildInputStats.__PropertyOffset_BuildersReferencedAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BuildersReferencedAssets.CopyAssign(value);
			}
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x000E0A39 File Offset: 0x000DEC39
		public FHLODBuildInputStats()
		{
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x000E0A41 File Offset: 0x000DEC41
		public FHLODBuildInputStats(TMap<FName, FHLODBuildInputReferencedAssets> BuildersReferencedAssets)
		{
			this.BuildersReferencedAssets = BuildersReferencedAssets;
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x000E0A50 File Offset: 0x000DEC50
		protected override IntPtr GetUStructPtr()
		{
			return FHLODBuildInputStats.StaticStruct();
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x000E0A5C File Offset: 0x000DEC5C
		[NullableContext(2)]
		public FHLODBuildInputStats(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x000E0A66 File Offset: 0x000DEC66
		public FHLODBuildInputStats(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x000E0A71 File Offset: 0x000DEC71
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODBuildInputStats(Pointer, false, true);
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x000E0A7B File Offset: 0x000DEC7B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODBuildInputStats(Pointer, MemoryOwner);
		}

		// Token: 0x04005721 RID: 22305
		public const string __ObjectPath = "/Script/Engine.HLODBuildInputStats";

		// Token: 0x04005722 RID: 22306
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005723 RID: 22307
		internal static int __PropertyOffset_BuildersReferencedAssets;

		// Token: 0x04005724 RID: 22308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FHLODBuildInputReferencedAssets> _BuildersReferencedAssets;
	}
}
