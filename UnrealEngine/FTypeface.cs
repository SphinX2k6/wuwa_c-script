using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002839 RID: 10297
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.Typeface")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FTypeface : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602644D RID: 156749 RVA: 0x003A1D5C File Offset: 0x0039FF5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTypeface._ScriptStructPtr != 0) ? FTypeface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.Typeface", ref FTypeface._ScriptStructPtr);
		}

		// Token: 0x170093C3 RID: 37827
		// (get) Token: 0x0602644E RID: 156750 RVA: 0x003A1D80 File Offset: 0x0039FF80
		// (set) Token: 0x0602644F RID: 156751 RVA: 0x003A1DC3 File Offset: 0x0039FFC3
		public TArray<FTypefaceEntry> Fonts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTypefaceEntry> result;
				if ((result = this._Fonts) == null)
				{
					result = (this._Fonts = new TArray<FTypefaceEntry>(base.NativePtr + (IntPtr)FTypeface.__PropertyOffset_Fonts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Fonts.CopyAssign(value);
			}
		}

		// Token: 0x06026450 RID: 156752 RVA: 0x003A1DD1 File Offset: 0x0039FFD1
		public FTypeface()
		{
		}

		// Token: 0x06026451 RID: 156753 RVA: 0x003A1DD9 File Offset: 0x0039FFD9
		public FTypeface(TArray<FTypefaceEntry> Fonts)
		{
			this.Fonts = Fonts;
		}

		// Token: 0x06026452 RID: 156754 RVA: 0x003A1DE8 File Offset: 0x0039FFE8
		protected override IntPtr GetUStructPtr()
		{
			return FTypeface.StaticStruct();
		}

		// Token: 0x06026453 RID: 156755 RVA: 0x003A1DF4 File Offset: 0x0039FFF4
		[NullableContext(2)]
		public FTypeface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026454 RID: 156756 RVA: 0x003A1DFE File Offset: 0x0039FFFE
		public FTypeface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026455 RID: 156757 RVA: 0x003A1E09 File Offset: 0x003A0009
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTypeface(Pointer, false, true);
		}

		// Token: 0x06026456 RID: 156758 RVA: 0x003A1E13 File Offset: 0x003A0013
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTypeface(Pointer, MemoryOwner);
		}

		// Token: 0x04014F3A RID: 85818
		public const string __ObjectPath = "/Script/SlateCore.Typeface";

		// Token: 0x04014F3B RID: 85819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F3C RID: 85820
		internal static int __PropertyOffset_Fonts;

		// Token: 0x04014F3D RID: 85821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTypefaceEntry> _Fonts;
	}
}
