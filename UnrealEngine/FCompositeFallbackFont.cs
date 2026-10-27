using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027F1 RID: 10225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.CompositeFallbackFont")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCompositeFallbackFont : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261D6 RID: 156118 RVA: 0x0039D37A File Offset: 0x0039B57A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositeFallbackFont._ScriptStructPtr != 0) ? FCompositeFallbackFont._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CompositeFallbackFont", ref FCompositeFallbackFont._ScriptStructPtr);
		}

		// Token: 0x17009323 RID: 37667
		// (get) Token: 0x060261D7 RID: 156119 RVA: 0x0039D3A0 File Offset: 0x0039B5A0
		// (set) Token: 0x060261D8 RID: 156120 RVA: 0x0039D3E3 File Offset: 0x0039B5E3
		public FTypeface Typeface
		{
			get
			{
				base.FastCheckIsValid();
				FTypeface result;
				if ((result = this._Typeface) == null)
				{
					result = (this._Typeface = new FTypeface(base.NativePtr + (IntPtr)FCompositeFallbackFont.__PropertyOffset_Typeface, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTypeface.StaticStruct(), base.NativePtr + (IntPtr)FCompositeFallbackFont.__PropertyOffset_Typeface, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009324 RID: 37668
		// (get) Token: 0x060261D9 RID: 156121 RVA: 0x0039D404 File Offset: 0x0039B604
		// (set) Token: 0x060261DA RID: 156122 RVA: 0x0039D414 File Offset: 0x0039B614
		public unsafe float ScalingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeFallbackFont.__PropertyOffset_ScalingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeFallbackFont.__PropertyOffset_ScalingFactor) = value;
			}
		}

		// Token: 0x060261DB RID: 156123 RVA: 0x0039D425 File Offset: 0x0039B625
		public FCompositeFallbackFont()
		{
		}

		// Token: 0x060261DC RID: 156124 RVA: 0x0039D42D File Offset: 0x0039B62D
		public FCompositeFallbackFont(FTypeface Typeface, float ScalingFactor)
		{
			this.Typeface = Typeface;
			this.ScalingFactor = ScalingFactor;
		}

		// Token: 0x060261DD RID: 156125 RVA: 0x0039D443 File Offset: 0x0039B643
		protected override IntPtr GetUStructPtr()
		{
			return FCompositeFallbackFont.StaticStruct();
		}

		// Token: 0x060261DE RID: 156126 RVA: 0x0039D44F File Offset: 0x0039B64F
		[NullableContext(2)]
		public FCompositeFallbackFont(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261DF RID: 156127 RVA: 0x0039D459 File Offset: 0x0039B659
		public FCompositeFallbackFont(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261E0 RID: 156128 RVA: 0x0039D464 File Offset: 0x0039B664
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositeFallbackFont(Pointer, false, true);
		}

		// Token: 0x060261E1 RID: 156129 RVA: 0x0039D46E File Offset: 0x0039B66E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositeFallbackFont(Pointer, MemoryOwner);
		}

		// Token: 0x04014D1D RID: 85277
		public const string __ObjectPath = "/Script/SlateCore.CompositeFallbackFont";

		// Token: 0x04014D1E RID: 85278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D1F RID: 85279
		internal static int __PropertyOffset_Typeface;

		// Token: 0x04014D20 RID: 85280
		[Nullable(2)]
		private FTypeface _Typeface;

		// Token: 0x04014D21 RID: 85281
		internal static int __PropertyOffset_ScalingFactor;
	}
}
