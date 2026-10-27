using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027BC RID: 10172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.MaterialOutputSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMaterialOutputSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025EE4 RID: 155364 RVA: 0x00398284 File Offset: 0x00396484
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialOutputSettings._ScriptStructPtr != 0) ? FMaterialOutputSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.MaterialOutputSettings", ref FMaterialOutputSettings._ScriptStructPtr);
		}

		// Token: 0x17009244 RID: 37444
		// (get) Token: 0x06025EE5 RID: 155365 RVA: 0x003982A8 File Offset: 0x003964A8
		// (set) Token: 0x06025EE6 RID: 155366 RVA: 0x003982C7 File Offset: 0x003964C7
		public TSoftObjectPtr<UMaterialInterface> ParentMaterialOverride
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInterface>(base.NativePtr + (IntPtr)FMaterialOutputSettings.__PropertyOffset_ParentMaterialOverride, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FMaterialOutputSettings.__PropertyOffset_ParentMaterialOverride, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06025EE7 RID: 155367 RVA: 0x003982EC File Offset: 0x003964EC
		public FMaterialOutputSettings()
		{
		}

		// Token: 0x06025EE8 RID: 155368 RVA: 0x003982F4 File Offset: 0x003964F4
		public FMaterialOutputSettings(TSoftObjectPtr<UMaterialInterface> ParentMaterialOverride)
		{
			this.ParentMaterialOverride = ParentMaterialOverride;
		}

		// Token: 0x06025EE9 RID: 155369 RVA: 0x00398303 File Offset: 0x00396503
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialOutputSettings.StaticStruct();
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x0039830F File Offset: 0x0039650F
		[NullableContext(2)]
		public FMaterialOutputSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025EEB RID: 155371 RVA: 0x00398319 File Offset: 0x00396519
		public FMaterialOutputSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025EEC RID: 155372 RVA: 0x00398324 File Offset: 0x00396524
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialOutputSettings(Pointer, false, true);
		}

		// Token: 0x06025EED RID: 155373 RVA: 0x0039832E File Offset: 0x0039652E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialOutputSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B41 RID: 84801
		public const string __ObjectPath = "/Script/SimplygonUObjects.MaterialOutputSettings";

		// Token: 0x04014B42 RID: 84802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B43 RID: 84803
		internal static int __PropertyOffset_ParentMaterialOverride;
	}
}
