using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000189 RID: 393
	[UnrealObjectPath("/Script/AIModule.EnvDirection")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEnvDirection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x000242C2 File Offset: 0x000224C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvDirection._ScriptStructPtr != 0) ? FEnvDirection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvDirection", ref FEnvDirection._ScriptStructPtr);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x000242E6 File Offset: 0x000224E6
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x000242FA File Offset: 0x000224FA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> LineFrom
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_LineFrom);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_LineFrom) = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0002430F File Offset: 0x0002250F
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x00024323 File Offset: 0x00022523
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> LineTo
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_LineTo);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_LineTo) = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00024338 File Offset: 0x00022538
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0002434C File Offset: 0x0002254C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> Rotation
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_Rotation);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x00024361 File Offset: 0x00022561
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x00024375 File Offset: 0x00022575
		public unsafe TEnumAsByte<EEnvDirection> DirMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_DirMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvDirection.__PropertyOffset_DirMode) = value;
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0002438A File Offset: 0x0002258A
		public FEnvDirection()
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00024392 File Offset: 0x00022592
		public FEnvDirection([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEnvQueryContext> LineFrom, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEnvQueryContext> LineTo, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEnvQueryContext> Rotation, TEnumAsByte<EEnvDirection> DirMode)
		{
			this.LineFrom = LineFrom;
			this.LineTo = LineTo;
			this.Rotation = Rotation;
			this.DirMode = DirMode;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000243B7 File Offset: 0x000225B7
		protected override IntPtr GetUStructPtr()
		{
			return FEnvDirection.StaticStruct();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000243C3 File Offset: 0x000225C3
		[NullableContext(2)]
		public FEnvDirection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000243CD File Offset: 0x000225CD
		public FEnvDirection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000243D8 File Offset: 0x000225D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvDirection(Pointer, false, true);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000243E2 File Offset: 0x000225E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvDirection(Pointer, MemoryOwner);
		}

		// Token: 0x040006D7 RID: 1751
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvDirection";

		// Token: 0x040006D8 RID: 1752
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040006D9 RID: 1753
		internal static int __PropertyOffset_LineFrom;

		// Token: 0x040006DA RID: 1754
		internal static int __PropertyOffset_LineTo;

		// Token: 0x040006DB RID: 1755
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040006DC RID: 1756
		internal static int __PropertyOffset_DirMode;
	}
}
