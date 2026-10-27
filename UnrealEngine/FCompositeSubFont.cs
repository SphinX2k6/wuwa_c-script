using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027F3 RID: 10227
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.CompositeSubFont")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FCompositeSubFont : FCompositeFallbackFont, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261F0 RID: 156144 RVA: 0x0039D60E File Offset: 0x0039B80E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositeSubFont._ScriptStructPtr != 0) ? FCompositeSubFont._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CompositeSubFont", ref FCompositeSubFont._ScriptStructPtr);
		}

		// Token: 0x17009328 RID: 37672
		// (get) Token: 0x060261F1 RID: 156145 RVA: 0x0039D634 File Offset: 0x0039B834
		// (set) Token: 0x060261F2 RID: 156146 RVA: 0x0039D677 File Offset: 0x0039B877
		public TArray<FInt32Range> CharacterRanges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInt32Range> result;
				if ((result = this._CharacterRanges) == null)
				{
					result = (this._CharacterRanges = new TArray<FInt32Range>(base.NativePtr + (IntPtr)FCompositeSubFont.__PropertyOffset_CharacterRanges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CharacterRanges.CopyAssign(value);
			}
		}

		// Token: 0x17009329 RID: 37673
		// (get) Token: 0x060261F3 RID: 156147 RVA: 0x0039D685 File Offset: 0x0039B885
		// (set) Token: 0x060261F4 RID: 156148 RVA: 0x0039D699 File Offset: 0x0039B899
		public unsafe string Cultures
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCompositeSubFont.__PropertyOffset_Cultures)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCompositeSubFont.__PropertyOffset_Cultures)), value);
			}
		}

		// Token: 0x060261F5 RID: 156149 RVA: 0x0039D6AE File Offset: 0x0039B8AE
		public FCompositeSubFont()
		{
		}

		// Token: 0x060261F6 RID: 156150 RVA: 0x0039D6B6 File Offset: 0x0039B8B6
		public FCompositeSubFont(TArray<FInt32Range> CharacterRanges, string Cultures, FName EditorName, FTypeface Typeface, float ScalingFactor)
		{
			this.CharacterRanges = CharacterRanges;
			this.Cultures = Cultures;
			base.Typeface = Typeface;
			base.ScalingFactor = ScalingFactor;
		}

		// Token: 0x060261F7 RID: 156151 RVA: 0x0039D6DC File Offset: 0x0039B8DC
		protected override IntPtr GetUStructPtr()
		{
			return FCompositeSubFont.StaticStruct();
		}

		// Token: 0x060261F8 RID: 156152 RVA: 0x0039D6E8 File Offset: 0x0039B8E8
		[NullableContext(2)]
		public FCompositeSubFont(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261F9 RID: 156153 RVA: 0x0039D6F2 File Offset: 0x0039B8F2
		public FCompositeSubFont(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261FA RID: 156154 RVA: 0x0039D6FD File Offset: 0x0039B8FD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositeSubFont(Pointer, false, true);
		}

		// Token: 0x060261FB RID: 156155 RVA: 0x0039D707 File Offset: 0x0039B907
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositeSubFont(Pointer, MemoryOwner);
		}

		// Token: 0x04014D2A RID: 85290
		public new const string __ObjectPath = "/Script/SlateCore.CompositeSubFont";

		// Token: 0x04014D2B RID: 85291
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D2C RID: 85292
		internal static int __PropertyOffset_CharacterRanges;

		// Token: 0x04014D2D RID: 85293
		[Nullable(2)]
		private TArray<FInt32Range> _CharacterRanges;

		// Token: 0x04014D2E RID: 85294
		internal static int __PropertyOffset_Cultures;
	}
}
