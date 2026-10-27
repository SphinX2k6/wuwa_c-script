using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027BB RID: 10171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.MaterialLODEditorInstanceSettings")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMaterialLODEditorInstanceSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025EDA RID: 155354 RVA: 0x003981EC File Offset: 0x003963EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialLODEditorInstanceSettings._ScriptStructPtr != 0) ? FMaterialLODEditorInstanceSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.MaterialLODEditorInstanceSettings", ref FMaterialLODEditorInstanceSettings._ScriptStructPtr);
		}

		// Token: 0x17009243 RID: 37443
		// (get) Token: 0x06025EDB RID: 155355 RVA: 0x00398210 File Offset: 0x00396410
		// (set) Token: 0x06025EDC RID: 155356 RVA: 0x00398224 File Offset: 0x00396424
		public unsafe string SamplerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMaterialLODEditorInstanceSettings.__PropertyOffset_SamplerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMaterialLODEditorInstanceSettings.__PropertyOffset_SamplerName)), value);
			}
		}

		// Token: 0x06025EDD RID: 155357 RVA: 0x00398239 File Offset: 0x00396439
		public FMaterialLODEditorInstanceSettings()
		{
		}

		// Token: 0x06025EDE RID: 155358 RVA: 0x00398241 File Offset: 0x00396441
		public FMaterialLODEditorInstanceSettings(string SamplerName)
		{
			this.SamplerName = SamplerName;
		}

		// Token: 0x06025EDF RID: 155359 RVA: 0x00398250 File Offset: 0x00396450
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialLODEditorInstanceSettings.StaticStruct();
		}

		// Token: 0x06025EE0 RID: 155360 RVA: 0x0039825C File Offset: 0x0039645C
		[NullableContext(2)]
		public FMaterialLODEditorInstanceSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025EE1 RID: 155361 RVA: 0x00398266 File Offset: 0x00396466
		public FMaterialLODEditorInstanceSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025EE2 RID: 155362 RVA: 0x00398271 File Offset: 0x00396471
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialLODEditorInstanceSettings(Pointer, false, true);
		}

		// Token: 0x06025EE3 RID: 155363 RVA: 0x0039827B File Offset: 0x0039647B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialLODEditorInstanceSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B3E RID: 84798
		public const string __ObjectPath = "/Script/SimplygonUObjects.MaterialLODEditorInstanceSettings";

		// Token: 0x04014B3F RID: 84799
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B40 RID: 84800
		internal static int __PropertyOffset_SamplerName;
	}
}
