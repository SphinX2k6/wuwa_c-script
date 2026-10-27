using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200283D RID: 10301
	[UnrealObjectPath("/Script/Slate.Anchors")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnchors : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602649B RID: 156827 RVA: 0x003A286C File Offset: 0x003A0A6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnchors._ScriptStructPtr != 0) ? FAnchors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.Anchors", ref FAnchors._ScriptStructPtr);
		}

		// Token: 0x170093DA RID: 37850
		// (get) Token: 0x0602649C RID: 156828 RVA: 0x003A2890 File Offset: 0x003A0A90
		// (set) Token: 0x0602649D RID: 156829 RVA: 0x003A28A4 File Offset: 0x003A0AA4
		public unsafe FVector2D Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170093DB RID: 37851
		// (get) Token: 0x0602649E RID: 156830 RVA: 0x003A28B9 File Offset: 0x003A0AB9
		// (set) Token: 0x0602649F RID: 156831 RVA: 0x003A28CD File Offset: 0x003A0ACD
		public unsafe FVector2D Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x060264A0 RID: 156832 RVA: 0x003A28E2 File Offset: 0x003A0AE2
		public FAnchors()
		{
		}

		// Token: 0x060264A1 RID: 156833 RVA: 0x003A28EA File Offset: 0x003A0AEA
		public FAnchors(FVector2D Minimum, FVector2D Maximum)
		{
			this.Minimum = Minimum;
			this.Maximum = Maximum;
		}

		// Token: 0x060264A2 RID: 156834 RVA: 0x003A2900 File Offset: 0x003A0B00
		protected override IntPtr GetUStructPtr()
		{
			return FAnchors.StaticStruct();
		}

		// Token: 0x060264A3 RID: 156835 RVA: 0x003A290C File Offset: 0x003A0B0C
		[NullableContext(2)]
		public FAnchors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060264A4 RID: 156836 RVA: 0x003A2916 File Offset: 0x003A0B16
		public FAnchors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060264A5 RID: 156837 RVA: 0x003A2921 File Offset: 0x003A0B21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnchors(Pointer, false, true);
		}

		// Token: 0x060264A6 RID: 156838 RVA: 0x003A292B File Offset: 0x003A0B2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnchors(Pointer, MemoryOwner);
		}

		// Token: 0x04014F6F RID: 85871
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Slate.Anchors";

		// Token: 0x04014F70 RID: 85872
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F71 RID: 85873
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04014F72 RID: 85874
		internal static int __PropertyOffset_Maximum;
	}
}
