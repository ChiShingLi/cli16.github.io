
## SELECTORS
**Basics**
*
.class
element
#id
selector1, selectorN, ...
```

## Hierarchy
```
parent &gt; child
ancestor descendant
prev + next
prev ~ siblings
Basic Filters
:animated
:eq()
:even
:first
:gt()
:header
:lang()
:last
:lt()
:not()
:odd
:root
:target
Content Filters
:contains()
:empty
:has()
:parent
Visibility Filters
:hidden
:visible
```

## Attribute
```
[name|="value"]
[name*="value"]
[name~="value"]
[name$="value"]
[name="value"]
[name!="value"]
[name^="value"]
[name]
[name="value"][name2="value2"]
```

## Child Filters
```
:first-child
:first-of-type
:last-child
:last-of-type
:nth-child()
:nth-last-child()
:nth-last-of-type()
:nth-of-type()
:only-child
:only-of-type()
```

## Forms
```
:button
:checkbox
:checked
:disabled
:enabled
:focus
:file
:image
:input
:password
:radio
:reset
:selected
:submit
:text
```
** ATTRIBUTES / CSS **
## Attributes
```
.attr()
.prop()
.removeAttr()
.removeProp()
.val()
```

## CSS
```
.addClass()
.css()
jQuery.cssHooks
jQuery.cssNumber
jQuery.escapeSelector()
.hasClass()
.removeClass()
.toggleClass()
```

## Dimensions
```
.height()
.innerHeight()
.innerWidth()
.outerHeight()
.outerWidth()
.width()
```

## Offset
```
.offset()
.offsetParent()
.position()
.scrollLeft()
.scrollTop()
```

## Data
```
jQuery.data()
.data()
jQuery.hasData()
jQuery.removeData()
.removeData()
```

## MANIPULATION
```
Copying
.clone()
```

## DOM Insertion, Around
```
.wrap()
.wrapAll()
.wrapInner()
```

## DOM Insertion, Inside
```
.append()
.appendTo()
.html()
.prepend()
.prependTo()
.text()
```

## DOM Insertion, Outside
```
.after()
.before()
.insertAfter()
.insertBefore()
```

## DOM Removal
```
.detach()
.empty()
.remove()
.unwrap()
```

## DOM Replacement
```
.replaceAll()
.replaceWith()
```

** TRAVERSING **
## Filtering
```
.eq()
.filter()
.first()
.has()
.is()
.last()
.map()
.not()
.slice()
```

## Miscellaneous Traversing
```
.add()
.addBack()
.andSelf()
.contents()
.each()
.end()
```

## Tree Traversal
```
.children()
.closest()
.find()
.next()
.nextAll()
.nextUntil()
.parent()
.parents()
.parentsUntil()
.prev()
.prevAll()
.prevUntil()
.siblings()
```

** EVENTS **

## Browser Events
```
.error()
.resize()
.scroll()
```

## Document Loading
```
.load()
.ready()
.unload()
```

## Event Handler Attachment
```
.bind()
.delegate()
.die()
.live()
.off()
.on()
.one()
.trigger()
.triggerHandler()
.unbind()
.undelegate()
```

## Form Events
```
.blur()
.change()
.focus()
.focusin()
.focusout()
.select()
.submit()
```

## Keyboard Events
```
.keydown()
.keypress()
.keyup()
```

## Mouse Events
```
.click()
.contextMenu()
.dblclick()
.hover()
.mousedown()
.mouseenter()
.mouseleave()
.mousemove()
.mouseout()
.mouseover()
.mouseup()
.toggle()
```

## Event Object
```
event.currentTarget
event.delegateTarget
event.data
event.isDefaultPrevented()
event.isImmediatePropagationStopped()
event.isPropagationStopped()
event.metaKey
event.namespace
event.pageX
event.pageY
event.preventDefault()
event.relatedTarget
event.result
event.stopImmediatePropagation()
event.stopPropagation()
event.target
event.timeStamp
event.type
event.which
```

** EFFECTS **
## Basics
```
.hide()
.show()
.toggle()
```

## Custom
```
.animate()
.clearQueue()
.delay()
.dequeue()
jQuery.dequeue()
.finish()
jQuery.fx.interval
jQuery.fx.off
jQuery.speed
.queue()
jQuery.queue()
.stop()
```

## Fading
```
.fadeIn()
.fadeOut()
.fadeTo()
.fadeToggle()
```

## Sliding
```
.slideDown()
.slideToggle()
.slideUp()
```

** AJAX **
## Global Ajax Event Handlers
```
.ajaxComplete()
.ajaxError()
.ajaxSend()
.ajaxStart()
.ajaxStop()
.ajaxSuccess()
```

** Helper Functions **
```
jQuery.param()
.serialize()
.serializeArray()
Low-Level Interface
jQuery.ajax()
jQuery.prefilter()
jQuery.ajaxSetup()
jQuery.ajaxTransport()
Shorthand Methods
jQuery.get()
jQuery.getJSON()
jQuery.getScript()
jQuery.post()
.load()
```

** CORE **
## jQuery Object
```
jQuery()
jQuery.noConflict()
jQuery.sub()
jQuery.holdReady()
jQuery.when()
```

## Deferred Object
```
jQuery.Deferred()
deferred.always()
deferred.done()
deferred.fail()
deferred.isRejected()
deferred.isResolved()
deferred.notify()
deferred.notifyWith()
deferred.pipe()
deferred.progress()
deferred.promise()
deferred.reject()
deferred.rejectWith()
deferred.resolve()
deferred.resolveWith()
deferred.state()
deferred.then()
.promise()
```

## Utilities
```
jQuery.boxModel
jQuery.browser
jQuery.contains()
jQuery.each()
jQuery.extend()
jQuery.globalEval()
jQuery.grep()
jQuery.inArray()
jQuery.isArray()
jQuery.isEmptyObject()
jQuery.isFunction()
jQuery.isNumeric()
jQuery.isPlainObject()
jQuery.isWindow()
jQuery.isXMLDoc()
jQuery.makeArray()
jQuery.map()
jQuery.merge()
jQuery.noop()
jQuery.now()
jQuery.parseHTML()
jQuery.parseJSON()
jQuery.parseXML()
jQuery.proxy()
jQuery.support
jQuery.trim()
jQuery.type()
jQuery.unique()
jQuery.uniqueSort()
```

## DOM Element Methods
```
.get()
.index()
.size()
.toArray()
```

## Internals
```
.jquery
.context
jQuery.error()
.length
.pushStack()
.selector
```

## Callbacks Object
```
jQuery.Callbacks()
callbacks.add()
callbacks.disable()
callbacks.disabled()
callbacks.empty()
callbacks.fire()
callbacks.fired()
callbacks.fireWith()
callbacks.has()
callbacks.lock()
callbacks.locked()
callbacks.remove()
```