using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027F2 RID: 10226
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.CompositeFont")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FCompositeFont : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261E2 RID: 156130 RVA: 0x0039D477 File Offset: 0x0039B677
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositeFont._ScriptStructPtr != 0) ? FCompositeFont._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CompositeFont", ref FCompositeFont._ScriptStructPtr);
		}

		// Token: 0x17009325 RID: 37669
		// (get) Token: 0x060261E3 RID: 156131 RVA: 0x0039D49C File Offset: 0x0039B69C
		// (set) Token: 0x060261E4 RID: 156132 RVA: 0x0039D4DF File Offset: 0x0039B6DF
		public FTypeface DefaultTypeface
		{
			get
			{
				base.FastCheckIsValid();
				FTypeface result;
				if ((result = this._DefaultTypeface) == null)
				{
					result = (this._DefaultTypeface = new FTypeface(base.NativePtr + (IntPtr)FCompositeFont.__PropertyOffset_DefaultTypeface, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTypeface.StaticStruct(), base.NativePtr + (IntPtr)FCompositeFont.__PropertyOffset_DefaultTypeface, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009326 RID: 37670
		// (get) Token: 0x060261E5 RID: 156133 RVA: 0x0039D500 File Offset: 0x0039B700
		// (set) Token: 0x060261E6 RID: 156134 RVA: 0x0039D543 File Offset: 0x0039B743
		public FCompositeFallbackFont FallbackTypeface
		{
			get
			{
				base.FastCheckIsValid();
				FCompositeFallbackFont result;
				if ((result = this._FallbackTypeface) == null)
				{
					result = (this._FallbackTypeface = new FCompositeFallbackFont(base.NativePtr + (IntPtr)FCompositeFont.__PropertyOffset_FallbackTypeface, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCompositeFallbackFont.StaticStruct(), base.NativePtr + (IntPtr)FCompositeFont.__PropertyOffset_FallbackTypeface, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009327 RID: 37671
		// (get) Token: 0x060261E7 RID: 156135 RVA: 0x0039D564 File Offset: 0x0039B764
		// (set) Token: 0x060261E8 RID: 156136 RVA: 0x0039D5A7 File Offset: 0x0039B7A7
		public TArray<FCompositeSubFont> SubTypefaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCompositeSubFont> result;
				if ((result = this._SubTypefaces) == null)
				{
					result = (this._SubTypefaces = new TArray<FCompositeSubFont>(base.NativePtr + (IntPtr)FCompositeFont.__PropertyOffset_SubTypefaces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubTypefaces.CopyAssign(value);
			}
		}

		// Token: 0x060261E9 RID: 156137 RVA: 0x0039D5B5 File Offset: 0x0039B7B5
		public FCompositeFont()
		{
		}

		// Token: 0x060261EA RID: 156138 RVA: 0x0039D5BD File Offset: 0x0039B7BD
		public FCompositeFont(FTypeface DefaultTypeface, FCompositeFallbackFont FallbackTypeface, TArray<FCompositeSubFont> SubTypefaces)
		{
			this.DefaultTypeface = DefaultTypeface;
			this.FallbackTypeface = FallbackTypeface;
			this.SubTypefaces = SubTypefaces;
		}

		// Token: 0x060261EB RID: 156139 RVA: 0x0039D5DA File Offset: 0x0039B7DA
		protected override IntPtr GetUStructPtr()
		{
			return FCompositeFont.StaticStruct();
		}

		// Token: 0x060261EC RID: 156140 RVA: 0x0039D5E6 File Offset: 0x0039B7E6
		[NullableContext(2)]
		public FCompositeFont(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261ED RID: 156141 RVA: 0x0039D5F0 File Offset: 0x0039B7F0
		public FCompositeFont(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261EE RID: 156142 RVA: 0x0039D5FB File Offset: 0x0039B7FB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositeFont(Pointer, false, true);
		}

		// Token: 0x060261EF RID: 156143 RVA: 0x0039D605 File Offset: 0x0039B805
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositeFont(Pointer, MemoryOwner);
		}

		// Token: 0x04014D22 RID: 85282
		public const string __ObjectPath = "/Script/SlateCore.CompositeFont";

		// Token: 0x04014D23 RID: 85283
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D24 RID: 85284
		internal static int __PropertyOffset_DefaultTypeface;

		// Token: 0x04014D25 RID: 85285
		[Nullable(2)]
		private FTypeface _DefaultTypeface;

		// Token: 0x04014D26 RID: 85286
		internal static int __PropertyOffset_FallbackTypeface;

		// Token: 0x04014D27 RID: 85287
		[Nullable(2)]
		private FCompositeFallbackFont _FallbackTypeface;

		// Token: 0x04014D28 RID: 85288
		internal static int __PropertyOffset_SubTypefaces;

		// Token: 0x04014D29 RID: 85289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCompositeSubFont> _SubTypefaces;
	}
}
