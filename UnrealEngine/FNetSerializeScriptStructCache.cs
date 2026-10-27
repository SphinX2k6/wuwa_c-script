using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013AB RID: 5035
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.NetSerializeScriptStructCache")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNetSerializeScriptStructCache : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127A0 RID: 75680 RVA: 0x001B29E2 File Offset: 0x001B0BE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNetSerializeScriptStructCache._ScriptStructPtr != 0) ? FNetSerializeScriptStructCache._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.NetSerializeScriptStructCache", ref FNetSerializeScriptStructCache._ScriptStructPtr);
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x060127A1 RID: 75681 RVA: 0x001B2A08 File Offset: 0x001B0C08
		// (set) Token: 0x060127A2 RID: 75682 RVA: 0x001B2A4B File Offset: 0x001B0C4B
		public TArray<UScriptStruct> ScriptStructs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UScriptStruct> result;
				if ((result = this._ScriptStructs) == null)
				{
					result = (this._ScriptStructs = new TArray<UScriptStruct>(base.NativePtr + (IntPtr)FNetSerializeScriptStructCache.__PropertyOffset_ScriptStructs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScriptStructs.CopyAssign(value);
			}
		}

		// Token: 0x060127A3 RID: 75683 RVA: 0x001B2A59 File Offset: 0x001B0C59
		public FNetSerializeScriptStructCache()
		{
		}

		// Token: 0x060127A4 RID: 75684 RVA: 0x001B2A61 File Offset: 0x001B0C61
		public FNetSerializeScriptStructCache(TArray<UScriptStruct> ScriptStructs)
		{
			this.ScriptStructs = ScriptStructs;
		}

		// Token: 0x060127A5 RID: 75685 RVA: 0x001B2A70 File Offset: 0x001B0C70
		protected override IntPtr GetUStructPtr()
		{
			return FNetSerializeScriptStructCache.StaticStruct();
		}

		// Token: 0x060127A6 RID: 75686 RVA: 0x001B2A7C File Offset: 0x001B0C7C
		[NullableContext(2)]
		public FNetSerializeScriptStructCache(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127A7 RID: 75687 RVA: 0x001B2A86 File Offset: 0x001B0C86
		public FNetSerializeScriptStructCache(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127A8 RID: 75688 RVA: 0x001B2A91 File Offset: 0x001B0C91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNetSerializeScriptStructCache(Pointer, false, true);
		}

		// Token: 0x060127A9 RID: 75689 RVA: 0x001B2A9B File Offset: 0x001B0C9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNetSerializeScriptStructCache(Pointer, MemoryOwner);
		}

		// Token: 0x04009E36 RID: 40502
		public const string __ObjectPath = "/Script/GameplayAbilities.NetSerializeScriptStructCache";

		// Token: 0x04009E37 RID: 40503
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E38 RID: 40504
		internal static int __PropertyOffset_ScriptStructs;

		// Token: 0x04009E39 RID: 40505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UScriptStruct> _ScriptStructs;
	}
}
