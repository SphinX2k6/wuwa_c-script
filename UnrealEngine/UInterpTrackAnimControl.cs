using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8A RID: 3210
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackAnimControl")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UInterpTrackAnimControl : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A305 RID: 41733 RVA: 0x000E7939 File Offset: 0x000E5B39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackAnimControl._ClassPtr;
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x000E7948 File Offset: 0x000E5B48
		public UInterpTrackAnimControl() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackAnimControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x000E7970 File Offset: 0x000E5B70
		public UInterpTrackAnimControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackAnimControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600A308 RID: 41736 RVA: 0x000E79A3 File Offset: 0x000E5BA3
		// (set) Token: 0x0600A309 RID: 41737 RVA: 0x000E79B7 File Offset: 0x000E5BB7
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600A30A RID: 41738 RVA: 0x000E79CC File Offset: 0x000E5BCC
		// (set) Token: 0x0600A30B RID: 41739 RVA: 0x000E7A05 File Offset: 0x000E5C05
		public TArray<FAnimControlTrackKey> AnimSeqs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimControlTrackKey> result;
				if ((result = this._AnimSeqs) == null)
				{
					result = (this._AnimSeqs = new TArray<FAnimControlTrackKey>(base.NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_AnimSeqs, this));
				}
				return result;
			}
			set
			{
				this.AnimSeqs.CopyAssign(value);
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x000E7A13 File Offset: 0x000E5C13
		// (set) Token: 0x0600A30D RID: 41741 RVA: 0x000E7A2C File Offset: 0x000E5C2C
		public unsafe bool bSkipAnimNotifiers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_bSkipAnimNotifiers) & UInterpTrackAnimControl.__PropertyMask_bSkipAnimNotifiers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_bSkipAnimNotifiers) = ((*(base.NativePtr + (IntPtr)UInterpTrackAnimControl.__PropertyOffset_bSkipAnimNotifiers) & ~UInterpTrackAnimControl.__PropertyMask_bSkipAnimNotifiers) | (value ? UInterpTrackAnimControl.__PropertyMask_bSkipAnimNotifiers : 0));
			}
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x000E7A5C File Offset: 0x000E5C5C
		static UInterpTrackAnimControl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackAnimControl");
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x000E7A6A File Offset: 0x000E5C6A
		protected UInterpTrackAnimControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005986 RID: 22918
		public new const string __ObjectPath = "/Script/Engine.InterpTrackAnimControl";

		// Token: 0x04005987 RID: 22919
		private static IntPtr _ClassPtr;

		// Token: 0x04005988 RID: 22920
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005989 RID: 22921
		internal static int __PropertyOffset_SlotName;

		// Token: 0x0400598A RID: 22922
		internal static int __PropertyOffset_AnimSeqs;

		// Token: 0x0400598B RID: 22923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimControlTrackKey> _AnimSeqs;

		// Token: 0x0400598C RID: 22924
		internal static int __PropertyOffset_bSkipAnimNotifiers;

		// Token: 0x0400598D RID: 22925
		internal static byte __PropertyMask_bSkipAnimNotifiers;
	}
}
