using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C7A RID: 3194
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpEdSelKey")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpEdSelKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A23E RID: 41534 RVA: 0x000E65D6 File Offset: 0x000E47D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpEdSelKey._ScriptStructPtr != 0) ? FInterpEdSelKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpEdSelKey", ref FInterpEdSelKey._ScriptStructPtr);
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600A23F RID: 41535 RVA: 0x000E65FA File Offset: 0x000E47FA
		// (set) Token: 0x0600A240 RID: 41536 RVA: 0x000E660E File Offset: 0x000E480E
		public unsafe UInterpGroup Group
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpGroup>(base.NativePtr / (IntPtr)sizeof(void*) + FInterpEdSelKey.__PropertyOffset_Group);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FInterpEdSelKey.__PropertyOffset_Group, value);
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600A241 RID: 41537 RVA: 0x000E6623 File Offset: 0x000E4823
		// (set) Token: 0x0600A242 RID: 41538 RVA: 0x000E6637 File Offset: 0x000E4837
		public unsafe UInterpTrack Track
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrack>(base.NativePtr / (IntPtr)sizeof(void*) + FInterpEdSelKey.__PropertyOffset_Track);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FInterpEdSelKey.__PropertyOffset_Track, value);
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x0600A243 RID: 41539 RVA: 0x000E664C File Offset: 0x000E484C
		// (set) Token: 0x0600A244 RID: 41540 RVA: 0x000E665C File Offset: 0x000E485C
		public unsafe int KeyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpEdSelKey.__PropertyOffset_KeyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpEdSelKey.__PropertyOffset_KeyIndex) = value;
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x000E666D File Offset: 0x000E486D
		// (set) Token: 0x0600A246 RID: 41542 RVA: 0x000E667D File Offset: 0x000E487D
		public unsafe float UnsnappedPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpEdSelKey.__PropertyOffset_UnsnappedPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpEdSelKey.__PropertyOffset_UnsnappedPosition) = value;
			}
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x000E668E File Offset: 0x000E488E
		public FInterpEdSelKey()
		{
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x000E6696 File Offset: 0x000E4896
		[NullableContext(1)]
		public FInterpEdSelKey(UInterpGroup Group, UInterpTrack Track, int KeyIndex, float UnsnappedPosition)
		{
			this.Group = Group;
			this.Track = Track;
			this.KeyIndex = KeyIndex;
			this.UnsnappedPosition = UnsnappedPosition;
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x000E66BB File Offset: 0x000E48BB
		protected override IntPtr GetUStructPtr()
		{
			return FInterpEdSelKey.StaticStruct();
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x000E66C7 File Offset: 0x000E48C7
		public FInterpEdSelKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x000E66D1 File Offset: 0x000E48D1
		public FInterpEdSelKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x000E66DC File Offset: 0x000E48DC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpEdSelKey(Pointer, false, true);
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x000E66E6 File Offset: 0x000E48E6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpEdSelKey(Pointer, MemoryOwner);
		}

		// Token: 0x04005908 RID: 22792
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpEdSelKey";

		// Token: 0x04005909 RID: 22793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400590A RID: 22794
		internal static int __PropertyOffset_Group;

		// Token: 0x0400590B RID: 22795
		internal static int __PropertyOffset_Track;

		// Token: 0x0400590C RID: 22796
		internal static int __PropertyOffset_KeyIndex;

		// Token: 0x0400590D RID: 22797
		internal static int __PropertyOffset_UnsnappedPosition;
	}
}
