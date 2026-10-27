using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D68 RID: 3432
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LODSoloTrack")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLODSoloTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B968 RID: 47464 RVA: 0x00107D03 File Offset: 0x00105F03
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLODSoloTrack._ScriptStructPtr != 0) ? FLODSoloTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LODSoloTrack", ref FLODSoloTrack._ScriptStructPtr);
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600B969 RID: 47465 RVA: 0x00107D28 File Offset: 0x00105F28
		// (set) Token: 0x0600B96A RID: 47466 RVA: 0x00107D6B File Offset: 0x00105F6B
		public TArray<byte> SoloEnableSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._SoloEnableSetting) == null)
				{
					result = (this._SoloEnableSetting = new TArray<byte>(base.NativePtr + (IntPtr)FLODSoloTrack.__PropertyOffset_SoloEnableSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoloEnableSetting.CopyAssign(value);
			}
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00107D79 File Offset: 0x00105F79
		public FLODSoloTrack()
		{
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x00107D81 File Offset: 0x00105F81
		public FLODSoloTrack(TArray<byte> SoloEnableSetting)
		{
			this.SoloEnableSetting = SoloEnableSetting;
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x00107D90 File Offset: 0x00105F90
		protected override IntPtr GetUStructPtr()
		{
			return FLODSoloTrack.StaticStruct();
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x00107D9C File Offset: 0x00105F9C
		[NullableContext(2)]
		public FLODSoloTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x00107DA6 File Offset: 0x00105FA6
		public FLODSoloTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x00107DB1 File Offset: 0x00105FB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLODSoloTrack(Pointer, false, true);
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x00107DBB File Offset: 0x00105FBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLODSoloTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04006125 RID: 24869
		public const string __ObjectPath = "/Script/Engine.LODSoloTrack";

		// Token: 0x04006126 RID: 24870
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006127 RID: 24871
		internal static int __PropertyOffset_SoloEnableSetting;

		// Token: 0x04006128 RID: 24872
		[Nullable(2)]
		private TArray<byte> _SoloEnableSetting;
	}
}
