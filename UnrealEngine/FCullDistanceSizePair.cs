using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000976 RID: 2422
	[UnrealObjectPath("/Script/Engine.CullDistanceSizePair")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FCullDistanceSizePair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008912 RID: 35090 RVA: 0x000C44B9 File Offset: 0x000C26B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCullDistanceSizePair._ScriptStructPtr != 0) ? FCullDistanceSizePair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CullDistanceSizePair", ref FCullDistanceSizePair._ScriptStructPtr);
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x000C44DD File Offset: 0x000C26DD
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x000C44ED File Offset: 0x000C26ED
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCullDistanceSizePair.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCullDistanceSizePair.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06008915 RID: 35093 RVA: 0x000C44FE File Offset: 0x000C26FE
		// (set) Token: 0x06008916 RID: 35094 RVA: 0x000C450E File Offset: 0x000C270E
		public unsafe float CullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCullDistanceSizePair.__PropertyOffset_CullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCullDistanceSizePair.__PropertyOffset_CullDistance) = value;
			}
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x000C451F File Offset: 0x000C271F
		public FCullDistanceSizePair()
		{
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x000C4527 File Offset: 0x000C2727
		public FCullDistanceSizePair(float Size, float CullDistance)
		{
			this.Size = Size;
			this.CullDistance = CullDistance;
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x000C453D File Offset: 0x000C273D
		protected override IntPtr GetUStructPtr()
		{
			return FCullDistanceSizePair.StaticStruct();
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x000C4549 File Offset: 0x000C2749
		[NullableContext(2)]
		public FCullDistanceSizePair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x000C4553 File Offset: 0x000C2753
		public FCullDistanceSizePair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x000C455E File Offset: 0x000C275E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCullDistanceSizePair(Pointer, false, true);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x000C4568 File Offset: 0x000C2768
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCullDistanceSizePair(Pointer, MemoryOwner);
		}

		// Token: 0x0400411B RID: 16667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CullDistanceSizePair";

		// Token: 0x0400411C RID: 16668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400411D RID: 16669
		internal static int __PropertyOffset_Size;

		// Token: 0x0400411E RID: 16670
		internal static int __PropertyOffset_CullDistance;
	}
}
