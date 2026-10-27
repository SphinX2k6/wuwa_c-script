using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200024C RID: 588
	[UnrealObjectPath("/Script/AkAudio.AkTriangle")]
	[UnrealStructLayout(8, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAkTriangle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060022C1 RID: 8897 RVA: 0x00033716 File Offset: 0x00031916
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkTriangle._ScriptStructPtr != 0) ? FAkTriangle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkTriangle", ref FAkTriangle._ScriptStructPtr);
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0003373A File Offset: 0x0003193A
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0003374A File Offset: 0x0003194A
		public unsafe ushort Point0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point0) = (short)value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0003375B File Offset: 0x0003195B
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0003376B File Offset: 0x0003196B
		public unsafe ushort Point1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point1) = (short)value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0003377C File Offset: 0x0003197C
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0003378C File Offset: 0x0003198C
		public unsafe ushort Point2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Point2) = (short)value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0003379D File Offset: 0x0003199D
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x000337AD File Offset: 0x000319AD
		public unsafe ushort Surface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Surface);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTriangle.__PropertyOffset_Surface) = (short)value;
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000337BE File Offset: 0x000319BE
		public FAkTriangle()
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000337C6 File Offset: 0x000319C6
		public FAkTriangle(ushort Point0, ushort Point1, ushort Point2, ushort Surface)
		{
			this.Point0 = Point0;
			this.Point1 = Point1;
			this.Point2 = Point2;
			this.Surface = Surface;
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000337EB File Offset: 0x000319EB
		protected override IntPtr GetUStructPtr()
		{
			return FAkTriangle.StaticStruct();
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000337F7 File Offset: 0x000319F7
		[NullableContext(2)]
		public FAkTriangle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00033801 File Offset: 0x00031A01
		public FAkTriangle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0003380C File Offset: 0x00031A0C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkTriangle(Pointer, false, true);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00033816 File Offset: 0x00031A16
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkTriangle(Pointer, MemoryOwner);
		}

		// Token: 0x04000C00 RID: 3072
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkTriangle";

		// Token: 0x04000C01 RID: 3073
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C02 RID: 3074
		internal static int __PropertyOffset_Point0;

		// Token: 0x04000C03 RID: 3075
		internal static int __PropertyOffset_Point1;

		// Token: 0x04000C04 RID: 3076
		internal static int __PropertyOffset_Point2;

		// Token: 0x04000C05 RID: 3077
		internal static int __PropertyOffset_Surface;
	}
}
