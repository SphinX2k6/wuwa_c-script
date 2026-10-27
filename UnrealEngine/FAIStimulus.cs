using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000112 RID: 274
	[UnrealObjectPath("/Script/AIModule.AIStimulus")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FAIStimulus : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001437 RID: 5175 RVA: 0x0001DD12 File Offset: 0x0001BF12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIStimulus._ScriptStructPtr != 0) ? FAIStimulus._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIStimulus", ref FAIStimulus._ScriptStructPtr);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0001DD36 File Offset: 0x0001BF36
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0001DD46 File Offset: 0x0001BF46
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Age);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Age) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0001DD57 File Offset: 0x0001BF57
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0001DD67 File Offset: 0x0001BF67
		public unsafe float ExpirationAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_ExpirationAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_ExpirationAge) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0001DD78 File Offset: 0x0001BF78
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0001DD88 File Offset: 0x0001BF88
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0001DD99 File Offset: 0x0001BF99
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0001DDAD File Offset: 0x0001BFAD
		public unsafe FVector StimulusLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_StimulusLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_StimulusLocation) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0001DDC2 File Offset: 0x0001BFC2
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0001DDD6 File Offset: 0x0001BFD6
		public unsafe FVector ReceiverLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_ReceiverLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_ReceiverLocation) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0001DDEB File Offset: 0x0001BFEB
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0001DDFF File Offset: 0x0001BFFF
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0001DE14 File Offset: 0x0001C014
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0001DE2D File Offset: 0x0001C02D
		public unsafe bool bSuccessfullySensed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_bSuccessfullySensed) & FAIStimulus.__PropertyMask_bSuccessfullySensed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_bSuccessfullySensed) = ((*(base.NativePtr + (IntPtr)FAIStimulus.__PropertyOffset_bSuccessfullySensed) & ~FAIStimulus.__PropertyMask_bSuccessfullySensed) | (value ? FAIStimulus.__PropertyMask_bSuccessfullySensed : 0));
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0001DE5D File Offset: 0x0001C05D
		public FAIStimulus()
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0001DE65 File Offset: 0x0001C065
		public FAIStimulus(float Age, float ExpirationAge, float Strength, FVector StimulusLocation, FVector ReceiverLocation, FName Tag, bool bSuccessfullySensed)
		{
			this.Age = Age;
			this.ExpirationAge = ExpirationAge;
			this.Strength = Strength;
			this.StimulusLocation = StimulusLocation;
			this.ReceiverLocation = ReceiverLocation;
			this.Tag = Tag;
			this.bSuccessfullySensed = bSuccessfullySensed;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0001DEA2 File Offset: 0x0001C0A2
		protected override IntPtr GetUStructPtr()
		{
			return FAIStimulus.StaticStruct();
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0001DEAE File Offset: 0x0001C0AE
		[NullableContext(2)]
		public FAIStimulus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0001DEB8 File Offset: 0x0001C0B8
		public FAIStimulus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0001DEC3 File Offset: 0x0001C0C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIStimulus(Pointer, false, true);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0001DECD File Offset: 0x0001C0CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIStimulus(Pointer, MemoryOwner);
		}

		// Token: 0x040003FC RID: 1020
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIStimulus";

		// Token: 0x040003FD RID: 1021
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003FE RID: 1022
		internal static int __PropertyOffset_Age;

		// Token: 0x040003FF RID: 1023
		internal static int __PropertyOffset_ExpirationAge;

		// Token: 0x04000400 RID: 1024
		internal static int __PropertyOffset_Strength;

		// Token: 0x04000401 RID: 1025
		internal static int __PropertyOffset_StimulusLocation;

		// Token: 0x04000402 RID: 1026
		internal static int __PropertyOffset_ReceiverLocation;

		// Token: 0x04000403 RID: 1027
		internal static int __PropertyOffset_Tag;

		// Token: 0x04000404 RID: 1028
		internal static int __PropertyOffset_bSuccessfullySensed;

		// Token: 0x04000405 RID: 1029
		internal static byte __PropertyMask_bSuccessfullySensed;
	}
}
