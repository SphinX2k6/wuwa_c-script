using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EAC RID: 3756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshUVChannelInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMeshUVChannelInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB49 RID: 52041 RVA: 0x0012849B File Offset: 0x0012669B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshUVChannelInfo._ScriptStructPtr != 0) ? FMeshUVChannelInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshUVChannelInfo", ref FMeshUVChannelInfo._ScriptStructPtr);
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600CB4A RID: 52042 RVA: 0x001284BF File Offset: 0x001266BF
		// (set) Token: 0x0600CB4B RID: 52043 RVA: 0x001284CF File Offset: 0x001266CF
		public unsafe bool bInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshUVChannelInfo.__PropertyOffset_bInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshUVChannelInfo.__PropertyOffset_bInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600CB4C RID: 52044 RVA: 0x001284E0 File Offset: 0x001266E0
		// (set) Token: 0x0600CB4D RID: 52045 RVA: 0x001284F0 File Offset: 0x001266F0
		public unsafe bool bOverrideDensities
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshUVChannelInfo.__PropertyOffset_bOverrideDensities) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshUVChannelInfo.__PropertyOffset_bOverrideDensities) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600CB4E RID: 52046 RVA: 0x00128504 File Offset: 0x00126704
		// (set) Token: 0x0600CB4F RID: 52047 RVA: 0x00128548 File Offset: 0x00126748
		public TFixedArray<float> LocalUVDensities
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._LocalUVDensities) == null)
				{
					result = (this._LocalUVDensities = new TFixedArray<float>(base.NativePtr + (IntPtr)FMeshUVChannelInfo.__PropertyOffset_LocalUVDensities, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalUVDensities.CopyAssign(value);
			}
		}

		// Token: 0x0600CB50 RID: 52048 RVA: 0x00128556 File Offset: 0x00126756
		public FMeshUVChannelInfo()
		{
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x0012855E File Offset: 0x0012675E
		public FMeshUVChannelInfo(bool bInitialized, bool bOverrideDensities, TFixedArray<float> LocalUVDensities)
		{
			this.bInitialized = bInitialized;
			this.bOverrideDensities = bOverrideDensities;
			this.LocalUVDensities = LocalUVDensities;
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x0012857B File Offset: 0x0012677B
		protected override IntPtr GetUStructPtr()
		{
			return FMeshUVChannelInfo.StaticStruct();
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x00128587 File Offset: 0x00126787
		[NullableContext(2)]
		public FMeshUVChannelInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB54 RID: 52052 RVA: 0x00128591 File Offset: 0x00126791
		public FMeshUVChannelInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x0012859C File Offset: 0x0012679C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshUVChannelInfo(Pointer, false, true);
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x001285A6 File Offset: 0x001267A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshUVChannelInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006D89 RID: 28041
		public const string __ObjectPath = "/Script/Engine.MeshUVChannelInfo";

		// Token: 0x04006D8A RID: 28042
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D8B RID: 28043
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x04006D8C RID: 28044
		internal static int __PropertyOffset_bOverrideDensities;

		// Token: 0x04006D8D RID: 28045
		internal static int __PropertyOffset_LocalUVDensities;

		// Token: 0x04006D8E RID: 28046
		[Nullable(2)]
		private TFixedArray<float> _LocalUVDensities;
	}
}
