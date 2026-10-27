using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000856 RID: 2134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetManagerRedirect")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAssetManagerRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600732B RID: 29483 RVA: 0x000A4FB7 File Offset: 0x000A31B7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetManagerRedirect._ScriptStructPtr != 0) ? FAssetManagerRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AssetManagerRedirect", ref FAssetManagerRedirect._ScriptStructPtr);
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x000A4FDB File Offset: 0x000A31DB
		// (set) Token: 0x0600732D RID: 29485 RVA: 0x000A4FEF File Offset: 0x000A31EF
		public unsafe string Old
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAssetManagerRedirect.__PropertyOffset_Old)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAssetManagerRedirect.__PropertyOffset_Old)), value);
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x0600732E RID: 29486 RVA: 0x000A5004 File Offset: 0x000A3204
		// (set) Token: 0x0600732F RID: 29487 RVA: 0x000A5018 File Offset: 0x000A3218
		public unsafe string New
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAssetManagerRedirect.__PropertyOffset_New)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAssetManagerRedirect.__PropertyOffset_New)), value);
			}
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x000A502D File Offset: 0x000A322D
		public FAssetManagerRedirect()
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x000A5035 File Offset: 0x000A3235
		public FAssetManagerRedirect(string Old, string New)
		{
			this.Old = Old;
			this.New = New;
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x000A504B File Offset: 0x000A324B
		protected override IntPtr GetUStructPtr()
		{
			return FAssetManagerRedirect.StaticStruct();
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x000A5057 File Offset: 0x000A3257
		[NullableContext(2)]
		public FAssetManagerRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x000A5061 File Offset: 0x000A3261
		public FAssetManagerRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x000A506C File Offset: 0x000A326C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetManagerRedirect(Pointer, false, true);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x000A5076 File Offset: 0x000A3276
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetManagerRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x0400375D RID: 14173
		public const string __ObjectPath = "/Script/Engine.AssetManagerRedirect";

		// Token: 0x0400375E RID: 14174
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400375F RID: 14175
		internal static int __PropertyOffset_Old;

		// Token: 0x04003760 RID: 14176
		internal static int __PropertyOffset_New;
	}
}
