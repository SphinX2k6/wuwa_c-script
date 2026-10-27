using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000948 RID: 2376
	[UnrealObjectPath("/Script/Engine.CollisionResponseTemplate")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FCollisionResponseTemplate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008682 RID: 34434 RVA: 0x000BFB68 File Offset: 0x000BDD68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionResponseTemplate._ScriptStructPtr != 0) ? FCollisionResponseTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionResponseTemplate", ref FCollisionResponseTemplate._ScriptStructPtr);
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06008683 RID: 34435 RVA: 0x000BFB8C File Offset: 0x000BDD8C
		// (set) Token: 0x06008684 RID: 34436 RVA: 0x000BFBA0 File Offset: 0x000BDDA0
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06008685 RID: 34437 RVA: 0x000BFBB5 File Offset: 0x000BDDB5
		// (set) Token: 0x06008686 RID: 34438 RVA: 0x000BFBC9 File Offset: 0x000BDDC9
		public unsafe TEnumAsByte<ECollisionEnabled> CollisionEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_CollisionEnabled);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_CollisionEnabled) = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06008687 RID: 34439 RVA: 0x000BFBDE File Offset: 0x000BDDDE
		// (set) Token: 0x06008688 RID: 34440 RVA: 0x000BFBEE File Offset: 0x000BDDEE
		public unsafe bool bCanModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_bCanModify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_bCanModify) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06008689 RID: 34441 RVA: 0x000BFBFF File Offset: 0x000BDDFF
		// (set) Token: 0x0600868A RID: 34442 RVA: 0x000BFC13 File Offset: 0x000BDE13
		public unsafe FName ObjectTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_ObjectTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_ObjectTypeName) = value;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x0600868B RID: 34443 RVA: 0x000BFC28 File Offset: 0x000BDE28
		// (set) Token: 0x0600868C RID: 34444 RVA: 0x000BFC6B File Offset: 0x000BDE6B
		[Nullable(1)]
		public TArray<FResponseChannel> CustomResponses
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FResponseChannel> result;
				if ((result = this._CustomResponses) == null)
				{
					result = (this._CustomResponses = new TArray<FResponseChannel>(base.NativePtr + (IntPtr)FCollisionResponseTemplate.__PropertyOffset_CustomResponses, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomResponses.CopyAssign(value);
			}
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x000BFC79 File Offset: 0x000BDE79
		public FCollisionResponseTemplate()
		{
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x000BFC81 File Offset: 0x000BDE81
		[NullableContext(1)]
		public FCollisionResponseTemplate(FName Name, [Nullable(0)] TEnumAsByte<ECollisionEnabled> CollisionEnabled, bool bCanModify, FName ObjectTypeName, TArray<FResponseChannel> CustomResponses, bool bConsiderNavigationRelevant, string HelpMessage)
		{
			this.Name = Name;
			this.CollisionEnabled = CollisionEnabled;
			this.bCanModify = bCanModify;
			this.ObjectTypeName = ObjectTypeName;
			this.CustomResponses = CustomResponses;
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x000BFCAE File Offset: 0x000BDEAE
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionResponseTemplate.StaticStruct();
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x000BFCBA File Offset: 0x000BDEBA
		[NullableContext(2)]
		public FCollisionResponseTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x000BFCC4 File Offset: 0x000BDEC4
		public FCollisionResponseTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x000BFCCF File Offset: 0x000BDECF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionResponseTemplate(Pointer, false, true);
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x000BFCD9 File Offset: 0x000BDED9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionResponseTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04003FFE RID: 16382
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollisionResponseTemplate";

		// Token: 0x04003FFF RID: 16383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004000 RID: 16384
		internal static int __PropertyOffset_Name;

		// Token: 0x04004001 RID: 16385
		internal static int __PropertyOffset_CollisionEnabled;

		// Token: 0x04004002 RID: 16386
		internal static int __PropertyOffset_bCanModify;

		// Token: 0x04004003 RID: 16387
		internal static int __PropertyOffset_ObjectTypeName;

		// Token: 0x04004004 RID: 16388
		internal static int __PropertyOffset_CustomResponses;

		// Token: 0x04004005 RID: 16389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FResponseChannel> _CustomResponses;
	}
}
