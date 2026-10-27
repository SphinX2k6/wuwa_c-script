using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000997 RID: 2455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataLayerInstanceNames")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FDataLayerInstanceNames : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008ABD RID: 35517 RVA: 0x000C6BCA File Offset: 0x000C4DCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDataLayerInstanceNames._ScriptStructPtr != 0) ? FDataLayerInstanceNames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DataLayerInstanceNames", ref FDataLayerInstanceNames._ScriptStructPtr);
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x000C6BEE File Offset: 0x000C4DEE
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x000C6BFE File Offset: 0x000C4DFE
		public unsafe bool bIsFirstDataLayerExternal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDataLayerInstanceNames.__PropertyOffset_bIsFirstDataLayerExternal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDataLayerInstanceNames.__PropertyOffset_bIsFirstDataLayerExternal) = (value ? 1 : 0);
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x000C6C10 File Offset: 0x000C4E10
		// (set) Token: 0x06008AC1 RID: 35521 RVA: 0x000C6C53 File Offset: 0x000C4E53
		public TArray<FName> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<FName>(base.NativePtr + (IntPtr)FDataLayerInstanceNames.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06008AC2 RID: 35522 RVA: 0x000C6C61 File Offset: 0x000C4E61
		// (set) Token: 0x06008AC3 RID: 35523 RVA: 0x000C6C75 File Offset: 0x000C4E75
		public unsafe FName PlatformDataLayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDataLayerInstanceNames.__PropertyOffset_PlatformDataLayer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDataLayerInstanceNames.__PropertyOffset_PlatformDataLayer) = value;
			}
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x000C6C8A File Offset: 0x000C4E8A
		public FDataLayerInstanceNames()
		{
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x000C6C92 File Offset: 0x000C4E92
		public FDataLayerInstanceNames(bool bIsFirstDataLayerExternal, TArray<FName> DataLayers, FName PlatformDataLayer)
		{
			this.bIsFirstDataLayerExternal = bIsFirstDataLayerExternal;
			this.DataLayers = DataLayers;
			this.PlatformDataLayer = PlatformDataLayer;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x000C6CAF File Offset: 0x000C4EAF
		protected override IntPtr GetUStructPtr()
		{
			return FDataLayerInstanceNames.StaticStruct();
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x000C6CBB File Offset: 0x000C4EBB
		[NullableContext(2)]
		public FDataLayerInstanceNames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x000C6CC5 File Offset: 0x000C4EC5
		public FDataLayerInstanceNames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x000C6CD0 File Offset: 0x000C4ED0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDataLayerInstanceNames(Pointer, false, true);
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x000C6CDA File Offset: 0x000C4EDA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDataLayerInstanceNames(Pointer, MemoryOwner);
		}

		// Token: 0x040041E2 RID: 16866
		public const string __ObjectPath = "/Script/Engine.DataLayerInstanceNames";

		// Token: 0x040041E3 RID: 16867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040041E4 RID: 16868
		internal static int __PropertyOffset_bIsFirstDataLayerExternal;

		// Token: 0x040041E5 RID: 16869
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x040041E6 RID: 16870
		[Nullable(2)]
		private TArray<FName> _DataLayers;

		// Token: 0x040041E7 RID: 16871
		internal static int __PropertyOffset_PlatformDataLayer;
	}
}
