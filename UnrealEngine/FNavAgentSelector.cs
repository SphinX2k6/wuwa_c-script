using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ECF RID: 3791
	[UnrealObjectPath("/Script/Engine.NavAgentSelector")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNavAgentSelector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CD23 RID: 52515 RVA: 0x0012AB80 File Offset: 0x00128D80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavAgentSelector._ScriptStructPtr != 0) ? FNavAgentSelector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavAgentSelector", ref FNavAgentSelector._ScriptStructPtr);
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600CD24 RID: 52516 RVA: 0x0012ABA4 File Offset: 0x00128DA4
		// (set) Token: 0x0600CD25 RID: 52517 RVA: 0x0012ABBD File Offset: 0x00128DBD
		public unsafe bool bSupportsAgent0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent0) & FNavAgentSelector.__PropertyMask_bSupportsAgent0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent0) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent0) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent0) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent0 : 0));
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600CD26 RID: 52518 RVA: 0x0012ABED File Offset: 0x00128DED
		// (set) Token: 0x0600CD27 RID: 52519 RVA: 0x0012AC06 File Offset: 0x00128E06
		public unsafe bool bSupportsAgent1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent1) & FNavAgentSelector.__PropertyMask_bSupportsAgent1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent1) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent1) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent1) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent1 : 0));
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x0012AC36 File Offset: 0x00128E36
		// (set) Token: 0x0600CD29 RID: 52521 RVA: 0x0012AC4F File Offset: 0x00128E4F
		public unsafe bool bSupportsAgent2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent2) & FNavAgentSelector.__PropertyMask_bSupportsAgent2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent2) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent2) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent2) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent2 : 0));
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600CD2A RID: 52522 RVA: 0x0012AC7F File Offset: 0x00128E7F
		// (set) Token: 0x0600CD2B RID: 52523 RVA: 0x0012AC98 File Offset: 0x00128E98
		public unsafe bool bSupportsAgent3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent3) & FNavAgentSelector.__PropertyMask_bSupportsAgent3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent3) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent3) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent3) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent3 : 0));
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600CD2C RID: 52524 RVA: 0x0012ACC8 File Offset: 0x00128EC8
		// (set) Token: 0x0600CD2D RID: 52525 RVA: 0x0012ACE1 File Offset: 0x00128EE1
		public unsafe bool bSupportsAgent4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent4) & FNavAgentSelector.__PropertyMask_bSupportsAgent4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent4) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent4) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent4) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent4 : 0));
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600CD2E RID: 52526 RVA: 0x0012AD11 File Offset: 0x00128F11
		// (set) Token: 0x0600CD2F RID: 52527 RVA: 0x0012AD2A File Offset: 0x00128F2A
		public unsafe bool bSupportsAgent5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent5) & FNavAgentSelector.__PropertyMask_bSupportsAgent5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent5) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent5) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent5) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent5 : 0));
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x0012AD5A File Offset: 0x00128F5A
		// (set) Token: 0x0600CD31 RID: 52529 RVA: 0x0012AD73 File Offset: 0x00128F73
		public unsafe bool bSupportsAgent6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent6) & FNavAgentSelector.__PropertyMask_bSupportsAgent6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent6) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent6) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent6) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent6 : 0));
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600CD32 RID: 52530 RVA: 0x0012ADA3 File Offset: 0x00128FA3
		// (set) Token: 0x0600CD33 RID: 52531 RVA: 0x0012ADBC File Offset: 0x00128FBC
		public unsafe bool bSupportsAgent7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent7) & FNavAgentSelector.__PropertyMask_bSupportsAgent7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent7) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent7) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent7) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent7 : 0));
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x0012ADEC File Offset: 0x00128FEC
		// (set) Token: 0x0600CD35 RID: 52533 RVA: 0x0012AE05 File Offset: 0x00129005
		public unsafe bool bSupportsAgent8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent8) & FNavAgentSelector.__PropertyMask_bSupportsAgent8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent8) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent8) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent8) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent8 : 0));
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600CD36 RID: 52534 RVA: 0x0012AE35 File Offset: 0x00129035
		// (set) Token: 0x0600CD37 RID: 52535 RVA: 0x0012AE4E File Offset: 0x0012904E
		public unsafe bool bSupportsAgent9
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent9) & FNavAgentSelector.__PropertyMask_bSupportsAgent9) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent9) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent9) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent9) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent9 : 0));
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x0012AE7E File Offset: 0x0012907E
		// (set) Token: 0x0600CD39 RID: 52537 RVA: 0x0012AE97 File Offset: 0x00129097
		public unsafe bool bSupportsAgent10
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent10) & FNavAgentSelector.__PropertyMask_bSupportsAgent10) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent10) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent10) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent10) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent10 : 0));
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x0012AEC7 File Offset: 0x001290C7
		// (set) Token: 0x0600CD3B RID: 52539 RVA: 0x0012AEE0 File Offset: 0x001290E0
		public unsafe bool bSupportsAgent11
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent11) & FNavAgentSelector.__PropertyMask_bSupportsAgent11) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent11) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent11) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent11) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent11 : 0));
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x0012AF10 File Offset: 0x00129110
		// (set) Token: 0x0600CD3D RID: 52541 RVA: 0x0012AF29 File Offset: 0x00129129
		public unsafe bool bSupportsAgent12
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent12) & FNavAgentSelector.__PropertyMask_bSupportsAgent12) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent12) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent12) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent12) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent12 : 0));
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x0012AF59 File Offset: 0x00129159
		// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x0012AF72 File Offset: 0x00129172
		public unsafe bool bSupportsAgent13
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent13) & FNavAgentSelector.__PropertyMask_bSupportsAgent13) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent13) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent13) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent13) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent13 : 0));
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x0012AFA2 File Offset: 0x001291A2
		// (set) Token: 0x0600CD41 RID: 52545 RVA: 0x0012AFBB File Offset: 0x001291BB
		public unsafe bool bSupportsAgent14
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent14) & FNavAgentSelector.__PropertyMask_bSupportsAgent14) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent14) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent14) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent14) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent14 : 0));
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600CD42 RID: 52546 RVA: 0x0012AFEB File Offset: 0x001291EB
		// (set) Token: 0x0600CD43 RID: 52547 RVA: 0x0012B004 File Offset: 0x00129204
		public unsafe bool bSupportsAgent15
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent15) & FNavAgentSelector.__PropertyMask_bSupportsAgent15) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent15) = ((*(base.NativePtr + (IntPtr)FNavAgentSelector.__PropertyOffset_bSupportsAgent15) & ~FNavAgentSelector.__PropertyMask_bSupportsAgent15) | (value ? FNavAgentSelector.__PropertyMask_bSupportsAgent15 : 0));
			}
		}

		// Token: 0x0600CD44 RID: 52548 RVA: 0x0012B034 File Offset: 0x00129234
		public FNavAgentSelector()
		{
		}

		// Token: 0x0600CD45 RID: 52549 RVA: 0x0012B03C File Offset: 0x0012923C
		public FNavAgentSelector(bool bSupportsAgent0, bool bSupportsAgent1, bool bSupportsAgent2, bool bSupportsAgent3, bool bSupportsAgent4, bool bSupportsAgent5, bool bSupportsAgent6, bool bSupportsAgent7, bool bSupportsAgent8, bool bSupportsAgent9, bool bSupportsAgent10, bool bSupportsAgent11, bool bSupportsAgent12, bool bSupportsAgent13, bool bSupportsAgent14, bool bSupportsAgent15)
		{
			this.bSupportsAgent0 = bSupportsAgent0;
			this.bSupportsAgent1 = bSupportsAgent1;
			this.bSupportsAgent2 = bSupportsAgent2;
			this.bSupportsAgent3 = bSupportsAgent3;
			this.bSupportsAgent4 = bSupportsAgent4;
			this.bSupportsAgent5 = bSupportsAgent5;
			this.bSupportsAgent6 = bSupportsAgent6;
			this.bSupportsAgent7 = bSupportsAgent7;
			this.bSupportsAgent8 = bSupportsAgent8;
			this.bSupportsAgent9 = bSupportsAgent9;
			this.bSupportsAgent10 = bSupportsAgent10;
			this.bSupportsAgent11 = bSupportsAgent11;
			this.bSupportsAgent12 = bSupportsAgent12;
			this.bSupportsAgent13 = bSupportsAgent13;
			this.bSupportsAgent14 = bSupportsAgent14;
			this.bSupportsAgent15 = bSupportsAgent15;
		}

		// Token: 0x0600CD46 RID: 52550 RVA: 0x0012B0CC File Offset: 0x001292CC
		protected override IntPtr GetUStructPtr()
		{
			return FNavAgentSelector.StaticStruct();
		}

		// Token: 0x0600CD47 RID: 52551 RVA: 0x0012B0D8 File Offset: 0x001292D8
		[NullableContext(2)]
		public FNavAgentSelector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x0012B0E2 File Offset: 0x001292E2
		public FNavAgentSelector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD49 RID: 52553 RVA: 0x0012B0ED File Offset: 0x001292ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavAgentSelector(Pointer, false, true);
		}

		// Token: 0x0600CD4A RID: 52554 RVA: 0x0012B0F7 File Offset: 0x001292F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavAgentSelector(Pointer, MemoryOwner);
		}

		// Token: 0x04006E5F RID: 28255
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavAgentSelector";

		// Token: 0x04006E60 RID: 28256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E61 RID: 28257
		internal static int __PropertyOffset_bSupportsAgent0;

		// Token: 0x04006E62 RID: 28258
		internal static byte __PropertyMask_bSupportsAgent0;

		// Token: 0x04006E63 RID: 28259
		internal static int __PropertyOffset_bSupportsAgent1;

		// Token: 0x04006E64 RID: 28260
		internal static byte __PropertyMask_bSupportsAgent1;

		// Token: 0x04006E65 RID: 28261
		internal static int __PropertyOffset_bSupportsAgent2;

		// Token: 0x04006E66 RID: 28262
		internal static byte __PropertyMask_bSupportsAgent2;

		// Token: 0x04006E67 RID: 28263
		internal static int __PropertyOffset_bSupportsAgent3;

		// Token: 0x04006E68 RID: 28264
		internal static byte __PropertyMask_bSupportsAgent3;

		// Token: 0x04006E69 RID: 28265
		internal static int __PropertyOffset_bSupportsAgent4;

		// Token: 0x04006E6A RID: 28266
		internal static byte __PropertyMask_bSupportsAgent4;

		// Token: 0x04006E6B RID: 28267
		internal static int __PropertyOffset_bSupportsAgent5;

		// Token: 0x04006E6C RID: 28268
		internal static byte __PropertyMask_bSupportsAgent5;

		// Token: 0x04006E6D RID: 28269
		internal static int __PropertyOffset_bSupportsAgent6;

		// Token: 0x04006E6E RID: 28270
		internal static byte __PropertyMask_bSupportsAgent6;

		// Token: 0x04006E6F RID: 28271
		internal static int __PropertyOffset_bSupportsAgent7;

		// Token: 0x04006E70 RID: 28272
		internal static byte __PropertyMask_bSupportsAgent7;

		// Token: 0x04006E71 RID: 28273
		internal static int __PropertyOffset_bSupportsAgent8;

		// Token: 0x04006E72 RID: 28274
		internal static byte __PropertyMask_bSupportsAgent8;

		// Token: 0x04006E73 RID: 28275
		internal static int __PropertyOffset_bSupportsAgent9;

		// Token: 0x04006E74 RID: 28276
		internal static byte __PropertyMask_bSupportsAgent9;

		// Token: 0x04006E75 RID: 28277
		internal static int __PropertyOffset_bSupportsAgent10;

		// Token: 0x04006E76 RID: 28278
		internal static byte __PropertyMask_bSupportsAgent10;

		// Token: 0x04006E77 RID: 28279
		internal static int __PropertyOffset_bSupportsAgent11;

		// Token: 0x04006E78 RID: 28280
		internal static byte __PropertyMask_bSupportsAgent11;

		// Token: 0x04006E79 RID: 28281
		internal static int __PropertyOffset_bSupportsAgent12;

		// Token: 0x04006E7A RID: 28282
		internal static byte __PropertyMask_bSupportsAgent12;

		// Token: 0x04006E7B RID: 28283
		internal static int __PropertyOffset_bSupportsAgent13;

		// Token: 0x04006E7C RID: 28284
		internal static byte __PropertyMask_bSupportsAgent13;

		// Token: 0x04006E7D RID: 28285
		internal static int __PropertyOffset_bSupportsAgent14;

		// Token: 0x04006E7E RID: 28286
		internal static byte __PropertyMask_bSupportsAgent14;

		// Token: 0x04006E7F RID: 28287
		internal static int __PropertyOffset_bSupportsAgent15;

		// Token: 0x04006E80 RID: 28288
		internal static byte __PropertyMask_bSupportsAgent15;
	}
}
