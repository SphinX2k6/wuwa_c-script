using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A7F RID: 10879
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseAcousticTextureCookedData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseAcousticTextureCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281A0 RID: 164256 RVA: 0x003D079D File Offset: 0x003CE99D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseAcousticTextureCookedData._ScriptStructPtr != 0) ? FWwiseAcousticTextureCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseAcousticTextureCookedData", ref FWwiseAcousticTextureCookedData._ScriptStructPtr);
		}

		// Token: 0x1700991C RID: 39196
		// (get) Token: 0x060281A1 RID: 164257 RVA: 0x003D07C1 File Offset: 0x003CE9C1
		// (set) Token: 0x060281A2 RID: 164258 RVA: 0x003D07D1 File Offset: 0x003CE9D1
		public unsafe int ShortId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseAcousticTextureCookedData.__PropertyOffset_ShortId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseAcousticTextureCookedData.__PropertyOffset_ShortId) = value;
			}
		}

		// Token: 0x1700991D RID: 39197
		// (get) Token: 0x060281A3 RID: 164259 RVA: 0x003D07E2 File Offset: 0x003CE9E2
		// (set) Token: 0x060281A4 RID: 164260 RVA: 0x003D07F6 File Offset: 0x003CE9F6
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseAcousticTextureCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseAcousticTextureCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x060281A5 RID: 164261 RVA: 0x003D080B File Offset: 0x003CEA0B
		public FWwiseAcousticTextureCookedData()
		{
		}

		// Token: 0x060281A6 RID: 164262 RVA: 0x003D0813 File Offset: 0x003CEA13
		public FWwiseAcousticTextureCookedData(int ShortId, FName DebugName)
		{
			this.ShortId = ShortId;
			this.DebugName = DebugName;
		}

		// Token: 0x060281A7 RID: 164263 RVA: 0x003D0829 File Offset: 0x003CEA29
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseAcousticTextureCookedData.StaticStruct();
		}

		// Token: 0x060281A8 RID: 164264 RVA: 0x003D0835 File Offset: 0x003CEA35
		[NullableContext(2)]
		public FWwiseAcousticTextureCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281A9 RID: 164265 RVA: 0x003D083F File Offset: 0x003CEA3F
		public FWwiseAcousticTextureCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281AA RID: 164266 RVA: 0x003D084A File Offset: 0x003CEA4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseAcousticTextureCookedData(Pointer, false, true);
		}

		// Token: 0x060281AB RID: 164267 RVA: 0x003D0854 File Offset: 0x003CEA54
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseAcousticTextureCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401601F RID: 90143
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseAcousticTextureCookedData";

		// Token: 0x04016020 RID: 90144
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016021 RID: 90145
		internal static int __PropertyOffset_ShortId;

		// Token: 0x04016022 RID: 90146
		internal static int __PropertyOffset_DebugName;
	}
}
