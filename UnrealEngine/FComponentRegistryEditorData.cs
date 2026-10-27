using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FD2 RID: 8146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ComponentRegistryEditorData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FComponentRegistryEditorData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE6A RID: 126570 RVA: 0x002DEC34 File Offset: 0x002DCE34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentRegistryEditorData._ScriptStructPtr != 0) ? FComponentRegistryEditorData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ComponentRegistryEditorData", ref FComponentRegistryEditorData._ScriptStructPtr);
		}

		// Token: 0x17007AF4 RID: 31476
		// (get) Token: 0x0601EE6B RID: 126571 RVA: 0x002DEC58 File Offset: 0x002DCE58
		// (set) Token: 0x0601EE6C RID: 126572 RVA: 0x002DEC6C File Offset: 0x002DCE6C
		public unsafe string ExportName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ExportName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ExportName)), value);
			}
		}

		// Token: 0x17007AF5 RID: 31477
		// (get) Token: 0x0601EE6D RID: 126573 RVA: 0x002DEC84 File Offset: 0x002DCE84
		// (set) Token: 0x0601EE6E RID: 126574 RVA: 0x002DECC7 File Offset: 0x002DCEC7
		public FRegisterRuntimeData RuntimeCacheData
		{
			get
			{
				base.FastCheckIsValid();
				FRegisterRuntimeData result;
				if ((result = this._RuntimeCacheData) == null)
				{
					result = (this._RuntimeCacheData = new FRegisterRuntimeData(base.NativePtr + (IntPtr)FComponentRegistryEditorData.__PropertyOffset_RuntimeCacheData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRegisterRuntimeData.StaticStruct(), base.NativePtr + (IntPtr)FComponentRegistryEditorData.__PropertyOffset_RuntimeCacheData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AF6 RID: 31478
		// (get) Token: 0x0601EE6F RID: 126575 RVA: 0x002DECE8 File Offset: 0x002DCEE8
		// (set) Token: 0x0601EE70 RID: 126576 RVA: 0x002DECFC File Offset: 0x002DCEFC
		public unsafe string ActorPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ActorPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ActorPath)), value);
			}
		}

		// Token: 0x17007AF7 RID: 31479
		// (get) Token: 0x0601EE71 RID: 126577 RVA: 0x002DED11 File Offset: 0x002DCF11
		// (set) Token: 0x0601EE72 RID: 126578 RVA: 0x002DED25 File Offset: 0x002DCF25
		public unsafe string ActorType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ActorType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComponentRegistryEditorData.__PropertyOffset_ActorType)), value);
			}
		}

		// Token: 0x0601EE73 RID: 126579 RVA: 0x002DED3A File Offset: 0x002DCF3A
		public FComponentRegistryEditorData()
		{
		}

		// Token: 0x0601EE74 RID: 126580 RVA: 0x002DED42 File Offset: 0x002DCF42
		public FComponentRegistryEditorData(string ExportName, FRegisterRuntimeData RuntimeCacheData, string ActorPath, string ActorType)
		{
			this.ExportName = ExportName;
			this.RuntimeCacheData = RuntimeCacheData;
			this.ActorPath = ActorPath;
			this.ActorType = ActorType;
		}

		// Token: 0x0601EE75 RID: 126581 RVA: 0x002DED67 File Offset: 0x002DCF67
		protected override IntPtr GetUStructPtr()
		{
			return FComponentRegistryEditorData.StaticStruct();
		}

		// Token: 0x0601EE76 RID: 126582 RVA: 0x002DED73 File Offset: 0x002DCF73
		[NullableContext(2)]
		public FComponentRegistryEditorData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE77 RID: 126583 RVA: 0x002DED7D File Offset: 0x002DCF7D
		public FComponentRegistryEditorData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE78 RID: 126584 RVA: 0x002DED88 File Offset: 0x002DCF88
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentRegistryEditorData(Pointer, false, true);
		}

		// Token: 0x0601EE79 RID: 126585 RVA: 0x002DED92 File Offset: 0x002DCF92
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentRegistryEditorData(Pointer, MemoryOwner);
		}

		// Token: 0x04010B0D RID: 68365
		public const string __ObjectPath = "/Script/LGUI.ComponentRegistryEditorData";

		// Token: 0x04010B0E RID: 68366
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B0F RID: 68367
		internal static int __PropertyOffset_ExportName;

		// Token: 0x04010B10 RID: 68368
		internal static int __PropertyOffset_RuntimeCacheData;

		// Token: 0x04010B11 RID: 68369
		[Nullable(2)]
		private FRegisterRuntimeData _RuntimeCacheData;

		// Token: 0x04010B12 RID: 68370
		internal static int __PropertyOffset_ActorPath;

		// Token: 0x04010B13 RID: 68371
		internal static int __PropertyOffset_ActorType;
	}
}
