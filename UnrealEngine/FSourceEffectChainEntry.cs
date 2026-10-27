using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001162 RID: 4450
	[UnrealObjectPath("/Script/Engine.SourceEffectChainEntry")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSourceEffectChainEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010432 RID: 66610 RVA: 0x0017F4D4 File Offset: 0x0017D6D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSourceEffectChainEntry._ScriptStructPtr != 0) ? FSourceEffectChainEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SourceEffectChainEntry", ref FSourceEffectChainEntry._ScriptStructPtr);
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x06010433 RID: 66611 RVA: 0x0017F4F8 File Offset: 0x0017D6F8
		// (set) Token: 0x06010434 RID: 66612 RVA: 0x0017F50C File Offset: 0x0017D70C
		[Nullable(2)]
		public unsafe USoundEffectSourcePreset Preset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSourcePreset>(base.NativePtr / (IntPtr)sizeof(void*) + FSourceEffectChainEntry.__PropertyOffset_Preset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSourceEffectChainEntry.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x06010435 RID: 66613 RVA: 0x0017F521 File Offset: 0x0017D721
		// (set) Token: 0x06010436 RID: 66614 RVA: 0x0017F53A File Offset: 0x0017D73A
		public unsafe bool bBypass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSourceEffectChainEntry.__PropertyOffset_bBypass) & FSourceEffectChainEntry.__PropertyMask_bBypass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSourceEffectChainEntry.__PropertyOffset_bBypass) = ((*(base.NativePtr + (IntPtr)FSourceEffectChainEntry.__PropertyOffset_bBypass) & ~FSourceEffectChainEntry.__PropertyMask_bBypass) | (value ? FSourceEffectChainEntry.__PropertyMask_bBypass : 0));
			}
		}

		// Token: 0x06010437 RID: 66615 RVA: 0x0017F56A File Offset: 0x0017D76A
		public FSourceEffectChainEntry()
		{
		}

		// Token: 0x06010438 RID: 66616 RVA: 0x0017F572 File Offset: 0x0017D772
		[NullableContext(1)]
		public FSourceEffectChainEntry(USoundEffectSourcePreset Preset, bool bBypass)
		{
			this.Preset = Preset;
			this.bBypass = bBypass;
		}

		// Token: 0x06010439 RID: 66617 RVA: 0x0017F588 File Offset: 0x0017D788
		protected override IntPtr GetUStructPtr()
		{
			return FSourceEffectChainEntry.StaticStruct();
		}

		// Token: 0x0601043A RID: 66618 RVA: 0x0017F594 File Offset: 0x0017D794
		[NullableContext(2)]
		public FSourceEffectChainEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601043B RID: 66619 RVA: 0x0017F59E File Offset: 0x0017D79E
		public FSourceEffectChainEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601043C RID: 66620 RVA: 0x0017F5A9 File Offset: 0x0017D7A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSourceEffectChainEntry(Pointer, false, true);
		}

		// Token: 0x0601043D RID: 66621 RVA: 0x0017F5B3 File Offset: 0x0017D7B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSourceEffectChainEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04008BF9 RID: 35833
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SourceEffectChainEntry";

		// Token: 0x04008BFA RID: 35834
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BFB RID: 35835
		internal static int __PropertyOffset_Preset;

		// Token: 0x04008BFC RID: 35836
		internal static int __PropertyOffset_bBypass;

		// Token: 0x04008BFD RID: 35837
		internal static byte __PropertyMask_bBypass;
	}
}
