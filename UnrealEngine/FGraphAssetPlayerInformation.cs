using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C10 RID: 3088
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GraphAssetPlayerInformation")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGraphAssetPlayerInformation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009C1E RID: 39966 RVA: 0x000DE040 File Offset: 0x000DC240
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGraphAssetPlayerInformation._ScriptStructPtr != 0) ? FGraphAssetPlayerInformation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GraphAssetPlayerInformation", ref FGraphAssetPlayerInformation._ScriptStructPtr);
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x000DE064 File Offset: 0x000DC264
		// (set) Token: 0x06009C20 RID: 39968 RVA: 0x000DE0A7 File Offset: 0x000DC2A7
		public TArray<int> PlayerNodeIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PlayerNodeIndices) == null)
				{
					result = (this._PlayerNodeIndices = new TArray<int>(base.NativePtr + (IntPtr)FGraphAssetPlayerInformation.__PropertyOffset_PlayerNodeIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlayerNodeIndices.CopyAssign(value);
			}
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x000DE0B5 File Offset: 0x000DC2B5
		public FGraphAssetPlayerInformation()
		{
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x000DE0BD File Offset: 0x000DC2BD
		public FGraphAssetPlayerInformation(TArray<int> PlayerNodeIndices)
		{
			this.PlayerNodeIndices = PlayerNodeIndices;
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x000DE0CC File Offset: 0x000DC2CC
		protected override IntPtr GetUStructPtr()
		{
			return FGraphAssetPlayerInformation.StaticStruct();
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x000DE0D8 File Offset: 0x000DC2D8
		[NullableContext(2)]
		public FGraphAssetPlayerInformation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x000DE0E2 File Offset: 0x000DC2E2
		public FGraphAssetPlayerInformation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x000DE0ED File Offset: 0x000DC2ED
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGraphAssetPlayerInformation(Pointer, false, true);
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x000DE0F7 File Offset: 0x000DC2F7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGraphAssetPlayerInformation(Pointer, MemoryOwner);
		}

		// Token: 0x04005630 RID: 22064
		public const string __ObjectPath = "/Script/Engine.GraphAssetPlayerInformation";

		// Token: 0x04005631 RID: 22065
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005632 RID: 22066
		internal static int __PropertyOffset_PlayerNodeIndices;

		// Token: 0x04005633 RID: 22067
		[Nullable(2)]
		private TArray<int> _PlayerNodeIndices;
	}
}
